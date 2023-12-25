using gym_rutiKroivets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Service
{
    internal interface IGuideService
    {
        public IEnumerable<Guide> Get();
        public Guide Get(int id);
        public void Post( Guide g);
        public void Put(int id, Guide g);
        public void Delete(int id);
    }
}
