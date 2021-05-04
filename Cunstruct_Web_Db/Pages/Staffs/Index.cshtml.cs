using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;
using Cunstruct_Web_Db.Data;

namespace Cunstruct_Web_Db.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly Cunstruct_Web_Db.Data.Cunstruct_Web_DbContext _context;

        public IndexModel(Cunstruct_Web_Db.Data.Cunstruct_Web_DbContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
