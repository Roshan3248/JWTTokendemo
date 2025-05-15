namespace JWTTokendemo.Data.Entities
{
    public class Sidebar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int StandardId { get; set; }
        public int SubjectId { get; set; }
        public int RoleId { get; set; }
    }
}
