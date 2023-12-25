using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Guide> Get()
        {
            return _guideService.Get();
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public ActionResult<Guide> Get(int id)
        {
            return _guideService.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Guide g)
        {
            return _guideService.Post(g);   
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guide g)
        {
            return _guideService.Put(id, g);    
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           return _guideService.Delete(id); 
        }
    }
}
