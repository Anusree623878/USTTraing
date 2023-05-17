using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserEmp.Data;
using UserEmp.Model;

namespace UserEmp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly UserEmp.Data.UserEmpContext _context;

        public DetailsModel(UserEmp.Data.UserEmpContext context)
        {
            _context = context;
        }

      public Employ Employ { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employ == null)
            {
                return NotFound();
            }

            var employ = await _context.Employ.FirstOrDefaultAsync(m => m.Id == id);
            if (employ == null)
            {
                return NotFound();
            }
            else 
            {
                Employ = employ;
            }
            return Page();
        }
    }
}
