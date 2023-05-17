using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UserEmp.Data;
using UserEmp.Model;

namespace UserEmp.Pages
{
    public class EditModel : PageModel
    {
        private readonly UserEmp.Data.UserEmpContext _context;

        public EditModel(UserEmp.Data.UserEmpContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employ Employ { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employ == null)
            {
                return NotFound();
            }

            var employ =  await _context.Employ.FirstOrDefaultAsync(m => m.Id == id);
            if (employ == null)
            {
                return NotFound();
            }
            Employ = employ;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployExists(Employ.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployExists(int id)
        {
          return (_context.Employ?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
