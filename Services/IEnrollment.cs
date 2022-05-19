using dss.Models;

namespace dss.Services
{
    public interface IEnrollment
    {
        IEnumerable<Enrollment> GetEnrollments { get; }

        Course GetEnrollment(int Id);
        void Add(Enrollment _Enrollment);
        void Remove(int Id);
    }
}
