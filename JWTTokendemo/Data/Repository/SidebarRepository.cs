using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;

namespace JWTTokendemo.Data.Repository
{
    public class SidebarRepository : ISidebar
    {
        private readonly ApplicationDbContext _context;

        public SidebarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddSidebar(Sidebar sidebar)
        {
            _context.Sidebars.Add(sidebar);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteSidebar(int id)
        {
            var sidebar = _context.Sidebars.FirstOrDefault(c => c.Id == id);
            _context.Sidebars.Remove(sidebar);
            _context.SaveChanges();
            return true;
        }

        public List<Sidebar> GetAllSidebar(int roleId)
        {
            return _context.Sidebars.Where(x=>x.RoleId == roleId).ToList();
        }

        public List<Sidebar> GetAllSidebarbyStandardIdandSubjectId(int StandardId, int SubjectId)
        {
            return _context.Sidebars.Where(x=>x.StandardId==StandardId && x.SubjectId==SubjectId).ToList();
        }

        public bool UpdateSidebar(Sidebar sidebar)
        {
            _context.Sidebars.Update(sidebar);
            _context.SaveChanges();
            return true;
        }
    }
}
