using JWTTokendemo.Data.Entities;
using JWTTokendemo.Data.Interface;

namespace JWTTokendemo.Data.Repository
{
    public class ChapterRepository : IChapter
    {
        private readonly ApplicationDbContext _context;

        public ChapterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddChapter(Chapter chapter)
        {
            _context.Chapters.Add(chapter);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteChapter(int id)
        {
            var chapter = _context.Chapters.FirstOrDefault(c => c.Id == id);
            _context.Chapters.Remove(chapter);
            _context.SaveChanges();
            return true;
        }

        public List<Chapter> GetAllChapter()
        {
            return _context.Chapters.ToList();
        }

        public bool UpdateChapter(Chapter chapter)
        {
            _context.Chapters.Update(chapter);
            _context.SaveChanges();
            return true;
        }
    }
}
