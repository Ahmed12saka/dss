using dss.Models;
using dss.Services;

namespace dss.Repository
{
    public class StudentRepository : IStudent
    {
        public IEnumerable<Student> GetStudents => throw new NotImplementedException();

        public void Add(Student _Student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int? Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int? Id)
        {
            throw new NotImplementedException();
        }
    }
}
