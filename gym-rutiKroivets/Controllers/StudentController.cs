using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static int Sid = 0;
        public static List<Student> students = new List<Student> { new Student { Id = ++Sid, Name = "defult", Address = "hadasim", Age = 0 } };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var stud= students.Find(s => s.Id == id);
            if (stud == null)
                return NotFound();
            else
                return stud;

        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Student s)
        {
            s.Id = ++Sid;
            students.Add(s);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student s)
        {
            var stud = students.Find(s => s.Id == id);
            stud.Name = s.Name;
            stud.Address = s.Address;
            stud.Age = s.Age;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var stud = students.Find(s => s.Id == id);
            students.Remove(stud);
        }
    }
}
