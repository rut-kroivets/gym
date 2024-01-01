using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    internal class TrainingService:ITrainingService
    {
        private readonly ITrainingRepository _trainingRepository;
        public TrainingService(ITrainingRepository context)
        {
            _trainingRepository = context;
        }
        public IEnumerable<Student> Get()
        {
            return _trainingRepository.Get();
        }
        public ActionResult<Student> Get(int id)
        {
            return _trainingRepository.Get(id);

        }
        public void Post(Student s)
        {
            _trainingRepository.Post(s);
        }
        public void Put(int id, [FromBody] Student s)
        {
            _trainingRepository.Put(id, s);
        }
        public void Delete(int id)
        {
            _trainingRepository.Delete(id);
        }
    }
}
