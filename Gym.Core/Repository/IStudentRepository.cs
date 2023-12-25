using gym_rutiKroivets.Entities;
using gym_rutiKroivets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Core.Repository
{
    internal interface IStudentRepository
    {
        public IEnumerable<Student> Get();

        public ActionResult<Student> Get(int id);

        public void Post( Student s);

        public void Put(int id, Student s);

        public void Delete(int id);

    }
}
