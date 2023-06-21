using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiwithcrud.Connection;
using webapiwithcrud.Model;

namespace webapiwithcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class ProductssController : ControllerBase

        {

            private readonly DbContextdemo _db;

            public ProductssController(DbContextdemo db)

            {

                _db = db;

            }

            [HttpPost]

            public ActionResult<DbContextdemo> Create([FromBody] DbContextdemo productList)

            {

                _db.DbContextdemos.Add(productList);

                _db.SaveChanges();

                return Ok(productList);

            }

            [HttpGet]

            public ActionResult<DbContextdemo> GetAll()

            {

                return Ok(_db.DbContextdemos.ToList());

            }

            [HttpGet("{id:int}")]

            public ActionResult<DbContextdemo> Get(int id)

            {

                var result = _db.DbContextdemos.Find(id);

                return Ok(result);

            }

            [HttpPut("{id:int}")]

            public ActionResult<DbContextdemo> Put([FromBody] DbContextdemo pro)

            {

                _db.DbContextdemos.Update(pro);

                _db.SaveChanges();

                return Ok(pro);

            }

            [HttpDelete("{id:int}")]

            public ActionResult<DbContextdemo> Delect(int id)

            {

                var result = _db.DbContextdemos.Find(id);

                 _db.DbContextdemos.Remove(result);

                _db.SaveChanges();

                return Ok();

            }

        }

}


