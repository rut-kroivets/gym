using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private static int Tid = 0;
        public static List<Training> trainings = new List<Training> { new Training { Id = ++Tid, Title = "defult", Day=0,Hour=0 } };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Training> Get()
        {
            return trainings;
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}/Day")]
        public ActionResult<IEnumerable<Training>> Get(int id, [FromBody] int day)
        {
            var train = trainings.FindAll(g => g.Day == day);
            if (train == null)
                return NotFound();
            else
                return train.ToList();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Training t)
        {
            t.Id = ++Tid;
            trainings.Add(t);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Training t)
        {
            var train = trainings.Find(i => i.Id == id);
            train.Title = t.Title;
            train.Day = t.Day;
            train.Hour = t.Hour;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var train = trainings.Find(i => i.Id == id);
            trainings.Remove(train);
        }
    }
}
