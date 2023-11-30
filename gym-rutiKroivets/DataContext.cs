using gym_rutiKroivets.Entities;
using System.Security.Cryptography;

namespace gym_rutiKroivets
{
    public class DataContext:IDataContext
    {
        public List<Guide> guides { get; set; }
        public List<Student> students { get; set; }
        public List<Training> trainings { get; set; }

        public DataContext()
        {
            guides = new List<Guide> { new Guide { Id = 1, Name = "defult", Address = "hadasim", Seniority = 0 } };
            students = new List<Student> { new Student { Id = 1, Name = "defult", Address = "hadasim", Age = 0 } };
            trainings = new List<Training> { new Training { Id = 1, Title = "defult", Day = 0, Hour = 0, Guid = new Guide { Id = 0, Name = "defult",
                Address = "hadasim", Seniority = 0 }, Students = new List<Student> { new Student { Id = 2, Name = "rivki", Address = "Pardo", Age = 19 } } } };
        }
    }
}
