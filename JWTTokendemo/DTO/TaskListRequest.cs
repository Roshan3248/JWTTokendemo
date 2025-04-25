using JWTTokendemo.Data.Entities;

namespace JWTTokendemo.DTO
{
    public class TaskListRequest
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string FirstName { get; set; }
        public string StatusName { get; set; }// navigation property

    }
}
