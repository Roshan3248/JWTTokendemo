using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.Data.Interface
{
    public interface ISubject
    {
        List<Subject> GetAllSubject();
        bool AddSubject(Subject subject);
        bool UpdateSubject(Subject subject);
        bool DeleteSubject(int id);

    }
}
