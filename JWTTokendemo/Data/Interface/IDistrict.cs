using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.Data.Interface
{
    public interface IDistrict
    {
        List<District> GetAllDistrict();
        bool AddDistrict(District district);
        bool UpdateDistrict(District district);
        bool DeleteDistrict(int id);
    }
}
