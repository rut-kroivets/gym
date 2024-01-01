using gym_rutiKroivets.Entities;
using gym_rutiKroivets.Gym.Core.Repository;
using gym_rutiKroivets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Data.Repository
{
    internal class GuideRepository:IGuideRepository
    {
        private readonly IDataContext _dataContext;
        public GuideRepository(IDataContext context)
        {
            _dataContext = context;
        }      
        public IEnumerable<Guide> Get()
        {
            return _dataContext.guides;
        }       
        public ActionResult<Guide> Get(int id)
        {
            var guid = _dataContext.guides.Find(g => g.Id == id);
            if (guid == null)
                return NotFound();
            else
                return guid;
        }      
        public void Post( Guide g)
        {
            var x = _dataContext.guides.Max(e => e.Id);
            g.Id = ++x;
            _dataContext.guides.Add(g);
        }
        public void Put(int id, Guide g)
        {
            var guide = _dataContext.guides.Find(i => i.Id == id);
            guide.Name = g.Name;
            guide.Address = g.Address;
            guide.Seniority = g.Seniority;
        }      
        public void Delete(int id)
        {
            var guide = _dataContext.guides.Find(i => i.Id == id);
            _dataContext.guides.Remove(guide);
        }
    }
}
