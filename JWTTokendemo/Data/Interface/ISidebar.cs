using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.Data.Interface
{
    public interface ISidebar
    {
        List<Sidebar> GetAllSidebar(int roleId);
        bool AddSidebar(Sidebar sidebar);
        bool UpdateSidebar(Sidebar sidebar);
        bool DeleteSidebar(int id);

        List<Sidebar> GetAllSidebarbyStandardIdandSubjectId(int StandardId, int SubjectId);
    }
}
