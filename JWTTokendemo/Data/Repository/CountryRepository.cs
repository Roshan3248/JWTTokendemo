using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;

namespace JWTTokendemo.Data.Repository
{
    public class CountryRepository : ICountry
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCountry(int id)
        {
            var country = _context.Countries.FirstOrDefault(c => c.Id == id);
            _context.Countries.Remove(country);
            _context.SaveChanges();
            return true;
        }

        public List<Country> GetAllCountry()
        {
            return _context.Countries.ToList();
        }

        public bool UpdateCountry(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
            return true;
        }
    }
}
