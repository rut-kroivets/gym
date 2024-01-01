﻿using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Repository
{
    internal interface ITrainingRepository
    {
        public IEnumerable<Student> Get();

        public ActionResult<Student> Get(int id);

        public void Post(Student s);

        public void Put(int id, Student s);

        public void Delete(int id);
    }
}
