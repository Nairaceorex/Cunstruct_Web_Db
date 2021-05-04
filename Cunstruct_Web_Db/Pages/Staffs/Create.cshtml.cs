using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConstructDB.Models;
using Cunstruct_Web_Db.Data;

namespace Cunstruct_Web_Db.Pages.Staffs
{
    public class CreateModel : PageModel
    {
        private readonly Cunstruct_Web_Db.Data.Cunstruct_Web_DbContext _context;

        public CreateModel(Cunstruct_Web_Db.Data.Cunstruct_Web_DbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Staff Staff { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Staff.Add(Staff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
