using gym_rutiKroivets;
using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    internal class GuideService: IGuideService
    {
        private readonly IGuideRepository _guideRepository;
        public GuideService(IGuideRepository context)
        {
            _guideRepository = context;
        }
        public Guide Get()
        {
            return _guideRepository.Get();
        }
        
        public ActionResult<Guide> Get(int id)
        {
            return _guideRepository.Get(id);
        }

        public void Post( Guide g)
        {
            return _guideRepository.Post(g);   
        }

        public void Put(int id, Guide g)
        {
            return _guideRepository.Put(id, g);
        }

        public void Delete(int id)
        {
            return _guideRepository.Delete(id); 
        }
    }
}
