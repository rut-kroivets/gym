using gym_rutiKroivets.Entities;

namespace gym_rutiKroivets
{
    public interface IDataContext
    {
        public List<Guide> guides { get; set; }
        public List<Student> students { get; set; }
        public List<Training> trainings { get; set; }

    }
}
