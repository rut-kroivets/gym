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
        private readonly IStudentService _studentService; 
        public StudentController(IStudentService context)
        {
            _studentService = context;
        }
    
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentService.Get();
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return _studentService.Get(id);

        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Student s)
        {
            _studentService.Post(s);    
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student s)
        {
            _studentService.Put(id, s); 
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentService.Delete(id); 
        }
    }
}
