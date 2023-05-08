using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Add new item in the table
            //using (var context = new EntityFrameworkExampleEntities())
            //{
               // var dept = new Dept()
               // {
                   // DeptId = 160,

                    //DeptName = "malayalam"
                //};
                //context.Depts.Add(dept);

                //context.SaveChanges();


            //}


           
            // Update table
           /* using (var context = new EntityFrameworkExampleEntities())
           {
                var std = context.Depts.Where(y=>y.DeptId==104).First<Dept>();
                std.DeptName = "SBA";
               context.SaveChanges();
            }*/

            using(var context = new EntityFrameworkExampleEntities())
            {
                var std=context.Dept.Where(y=>y.DeptId==114).First<Dept>();
                context.Dept.Remove(std);
                context.SaveChanges();
            }

            EntityFrameworkExampleEntities em = new EntityFrameworkExampleEntities();
            foreach (var entity in em.Dept)
            {
                Console.WriteLine(entity.DeptName);
            }


        }
    }
}
