using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.Data.Interface
{
    public interface IStandard
    {
        List<Standard> GetAllStandard();
        bool AddStandard(Standard standard);
        bool UpdateStandard(Standard standard);
        bool DeleteStandard(int id);

    }
}
