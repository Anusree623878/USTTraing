using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserEmp.Model;

namespace UserEmp.Data
{
    public class UserEmpContext : DbContext
    {
        public UserEmpContext (DbContextOptions<UserEmpContext> options)
            : base(options)
        {
        }

        public DbSet<UserEmp.Model.Employ> Employ { get; set; } = default!;
    }
}
