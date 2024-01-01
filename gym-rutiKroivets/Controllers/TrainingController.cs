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
        private readonly ITrainingService _trainingService;
        public TrainingController(ITrainingService context)
        {
            _trainingService = context;   
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Training> Get()
        {
            return _trainingService.Get();
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}/Day")]
        public ActionResult<IEnumerable<Training>> Get(int id, [FromBody] int day)
        {
            return _trainingService.Get(id, day);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Training t)
        {
            _trainingService.Post(t);   
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Training t)
        {
            _trainingService.Put(id, t);    
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _trainingService.Delete(id);    
        }
    }
}
