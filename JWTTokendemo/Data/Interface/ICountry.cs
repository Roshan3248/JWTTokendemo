using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.Data.Interface
{
    public interface ICountry
    {
        List<Country> GetAllCountry();
        bool AddCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(int id);
    }
}
