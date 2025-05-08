using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;

namespace JWTTokendemo.Data.Repository
{
    public class StandardRepository : IStandard
    {
        private readonly ApplicationDbContext _context;

        public StandardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStandard(Standard standard)
        {
            _context.Standards.Add(standard);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteStandard(int id)
        {
            var standard = _context.Standards.FirstOrDefault(c => c.Id == id);
            _context.Standards.Remove(standard);
            _context.SaveChanges();
            return true;
        }

        public List<Standard> GetAllStandard()
        {
            return _context.Standards.ToList();
        }

        public bool UpdateStandard(Standard standard)
        {
            _context.Standards.Update(standard);
            _context.SaveChanges();
            return true;
        }
    }
}
