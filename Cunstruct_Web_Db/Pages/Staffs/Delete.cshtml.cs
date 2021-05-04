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
    public class DeleteModel : PageModel
    {
        private readonly Cunstruct_Web_Db.Data.Cunstruct_Web_DbContext _context;

        public DeleteModel(Cunstruct_Web_Db.Data.Cunstruct_Web_DbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staff Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staff = await _context.Staff.FirstOrDefaultAsync(m => m.ID == id);

            if (Staff == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staff = await _context.Staff.FindAsync(id);

            if (Staff != null)
            {
                _context.Staff.Remove(Staff);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
