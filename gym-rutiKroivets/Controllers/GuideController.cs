using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {
        private readonly IDataContext _dataContext;
        public GuideController( IDataContext context)
        {
            _dataContext = context; 
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Guide> Get()
        {
            return _dataContext.guides;
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public ActionResult<Guide> Get(int id)
        {
            var guid= _dataContext.guides.Find(g => g.Id == id);
            if (guid == null)
                return NotFound();
            else
                return guid;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Guide g)
        {
            var x = _dataContext.guides.Max(e => e.Id);
            g.Id =++x;
            _dataContext.guides.Add(g);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guide g)
        {
            var guide = _dataContext.guides.Find(i => i.Id == id);
            guide.Name = g.Name;
            guide.Address = g.Address;
            guide.Seniority = g.Seniority;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var guide = _dataContext.guides.Find(i => i.Id == id);
            _dataContext.guides.Remove(guide);
        }
    }
}
