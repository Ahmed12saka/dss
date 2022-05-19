using dss.Models;
using dss.Services;

namespace dss.Repository
{
    public class SchoolRepository : ISchool
    {
        private DBContext db;

        public SchoolRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<School> GetSchools => db.Schools;

        public void Add(School _School)
        {
            db.Schools.Add(_School);
            db.SaveChanges();
        }

        public School GetFaculty(int Id)
        {
            School dbEntitiy = db.Schools.Find(Id);
            return dbEntitiy;
        }

        public void Remove(int Id)
        {
            School dbEntity = db.Schools.Find(Id);
            db.Schools.Remove(dbEntity);
        }
    }
}
