using dss.Models;
using dss.Services;

namespace dss.Repository
{
    public class EnrollmentRepository : IEnrollment
    {
        public IEnumerable<Enrollment> GetEnrollments => throw new NotImplementedException();

        public void Add(Enrollment _Enrollment)
        {
            throw new NotImplementedException();
        }

        public Course GetEnrollment(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
