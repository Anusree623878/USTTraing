using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Data;
using SchoolProject.Model;

namespace SchoolProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            _db.Add(student);
            _db.SaveChanges();
            return Ok(student);
        }

        //[HttpGet]





    
    }

}
