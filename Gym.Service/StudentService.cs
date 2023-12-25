using gym_rutiKroivets.Entities;
using gym_rutiKroivets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    internal class StudentService: IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository context)
        {
            _studentRepository = context;
        }       
        public IEnumerable<Student> Get()
        {
            return _studentRepository.Get();
        }        
        public ActionResult<Student> Get(int id)
        {
            return _studentRepository.Get(id); 

        }
        public void Post( Student s)
        {
            _studentRepository.Post(s); 
        }
        public void Put(int id, [FromBody] Student s)
        {
            _studentRepository.Put(id, s);  
        }
        public void Delete(int id)
        {
            _studentRepository.Delete(id);  
        }
    }
}
