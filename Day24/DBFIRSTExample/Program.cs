using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DBFIRSTExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DBFIRSTEntities())
            {
                var std = new Project()
                {
                    ProjectId = "P009",
                    ProjectName = "Gatfes"
                };
                context.Projects.Add(std);

                context.SaveChanges();
            }

            DBFIRSTEntities db=new DBFIRSTEntities();

                    foreach (var project in db.Projects)
                {
                    Console.WriteLine(project.ProjectId);
                    Console.WriteLine(project.ProjectName);
                }
                
            
        }


        
    }
}
