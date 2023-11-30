using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly IDataContext _dataContext;
        public TrainingController(IDataContext context)
        {
            _dataContext=context;   
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Training> Get()
        {
            return _dataContext.trainings;
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}/Day")]
        public ActionResult<IEnumerable<Training>> Get(int id, [FromBody] int day)
        {
            var train = _dataContext.trainings.FindAll(g => g.Day == day);
            if (train == null)
                return NotFound();
            else
                return train.ToList();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Training t)
        {
            var x = _dataContext.trainings.Max(e => e.Id);
            t.Id = ++x;
            _dataContext.trainings.Add(t);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Training t)
        {
            var train = _dataContext.trainings.Find(i => i.Id == id);
            train.Title = t.Title;
            train.Day = t.Day;
            train.Hour = t.Hour;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var train = _dataContext.trainings.Find(i => i.Id == id);
            _dataContext.trainings.Remove(train);
        }
    }
}
