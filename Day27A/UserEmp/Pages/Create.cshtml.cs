using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UserEmp.Data;
using UserEmp.Model;

namespace UserEmp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly UserEmp.Data.UserEmpContext _context;

        public CreateModel(UserEmp.Data.UserEmpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employ Employ { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Employ == null || Employ == null)
            {
                return Page();
            }

            _context.Employ.Add(Employ);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
