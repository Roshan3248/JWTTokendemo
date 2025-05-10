using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.Data.Interface
{
    public interface IChapter
    {
        List<Chapter> GetAllChapter();
        bool AddChapter(Chapter chapter);
        bool UpdateChapter(Chapter chapter);
        bool DeleteChapter(int id);

        List<Chapter> GetAllChapterbyStandardIdandSubjectId(int StandardId, int SubjectId);
    }
}
