namespace JWTTokendemo.DTO
{
    public class AddTaskRequest
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
    }
}
