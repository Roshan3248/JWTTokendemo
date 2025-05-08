namespace JWTTokendemo.Data.Entities
{
    public class Chapter
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StandardId { get; set; }
        public int SubjectId { get; set; }

    }
}
