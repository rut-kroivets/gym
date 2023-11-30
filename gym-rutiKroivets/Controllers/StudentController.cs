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
        private readonly IDataContext _dataContext; 
        public StudentController(IDataContext context)
        {
            _dataContext = context;
        }
    
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _dataContext.students;
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var stud= _dataContext.students.Find(s => s.Id == id);
            if (stud == null)
                return NotFound();
            else
                return stud;

        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Student s)
        {
           var x= _dataContext.students.Max(s => s.Id); 
            s.Id = ++x;
            _dataContext.students.Add(s);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student s)
        {
            var stud = _dataContext.students.Find(s => s.Id == id);
            stud.Name = s.Name;
            stud.Address = s.Address;
            stud.Age = s.Age;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var stud = _dataContext.students.Find(s => s.Id == id);
            _dataContext.students.Remove(stud);
        }
    }
}
