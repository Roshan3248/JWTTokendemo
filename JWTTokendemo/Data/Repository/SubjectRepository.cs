using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;

namespace JWTTokendemo.Data.Repository
{
    public class SubjectRepository : ISubject
    {
        private readonly ApplicationDbContext _context;

        public SubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteSubject(int id)
        {
            var subject = _context.Subjects.FirstOrDefault(c => c.Id == id);
            _context.Subjects.Remove(subject);
            _context.SaveChanges();
            return true;
        }

        public List<Subject> GetAllSubject()
        {
            return _context.Subjects.ToList();
        }

        public bool UpdateSubject(Subject subject)
        {
            _context.Subjects.Update(subject);
            _context.SaveChanges();
            return true;
        }
    }
}
