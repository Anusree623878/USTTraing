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
    public class IndexModel : PageModel
    {
        private readonly UserEmp.Data.UserEmpContext _context;

        public IndexModel(UserEmp.Data.UserEmpContext context)
        {
            _context = context;
        }

        public IList<Employ> Employ { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employ != null)
            {
                Employ = await _context.Employ.ToListAsync();
            }
        }
    }
}
