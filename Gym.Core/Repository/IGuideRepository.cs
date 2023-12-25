using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Repository
{
    internal interface IGuideRepository
    {
        public IEnumerable<Guide> Get();
        public ActionResult<Guide> Get(int id);
        public void Post(Guide g);
        public void Put(int id, Guide g);
        public void Delete(int id);
    }
}
