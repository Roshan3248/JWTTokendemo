using JWTTokendemo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTTokendemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<State>States  { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

        public DbSet<TaskManager> TaskManagers { get; set; }

        public DbSet<Standard> Standards { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Teacher" },
                new Role { Id = 3, Name = "Student" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "anil@gmail.com", Firstname = "Anil", Lastname = "Sah", Password = "Anil@123", Mobile = "9808000008" },
                new User { Id = 2, Email = "raju@gmail.com", Firstname = "Raju", Lastname = "Chauhan", Password = "Raju@123", Mobile = "9808009797" },
                new User { Id = 3, Email = "avijit@gmail.com", Firstname = "Avijit", Lastname = "Gorai", Password = "Avijit@123", Mobile = "998989797" }
            );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, UserId = 1, RoleId = 1 },
                new UserRole { Id = 2, UserId = 2, RoleId = 2 },
                new UserRole { Id = 3, UserId = 3, RoleId = 3 });

            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, StatusName = "To Do" },
                new Status { Id = 2, StatusName = "In Progress" },
                new Status { Id = 3, StatusName = "Testing" },
                new Status { Id = 4, StatusName = "Done" }
            );
            modelBuilder.Entity<Standard>().HasData(
    new Standard { Id = 1, Name = "Standard 1" },
    new Standard { Id = 2, Name = "Standard 2" },
    new Standard { Id = 3, Name = "Standard 3" }
);
            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Mathematics" },
                new Subject { Id = 2, Name = "English" },
                new Subject { Id = 4, Name = "Computer" }
            );
            modelBuilder.Entity<Chapter>().HasData(
                new Chapter { Id = 1, Name = "Addition", StandardId = 1, SubjectId = 1 },
                new Chapter { Id = 2, Name = "Subtraction", StandardId = 1, SubjectId = 1 },
                new Chapter { Id = 3, Name = "Multiplication", StandardId = 1, SubjectId = 1 },
                new Chapter { Id = 4, Name = "Division", StandardId = 1, SubjectId = 1 },
                new Chapter { Id = 5, Name = "Time", StandardId = 1, SubjectId = 1 },
                new Chapter { Id = 6, Name = "Money", StandardId = 1, SubjectId = 1 },
                new Chapter { Id = 7, Name = "Addition", StandardId = 1, SubjectId = 2 },
                new Chapter { Id = 8, Name = "Subtraction", StandardId = 1, SubjectId = 2 },
                new Chapter { Id = 9, Name = "Multiplication", StandardId = 1, SubjectId = 2 },
                new Chapter { Id = 10, Name = "Division", StandardId = 1, SubjectId = 2 },
                new Chapter { Id = 11, Name = "Time", StandardId = 1, SubjectId = 2 },
                new Chapter { Id = 12, Name = "Money", StandardId = 1, SubjectId = 2 },
                new Chapter { Id = 13, Name = "Addition", StandardId = 1, SubjectId = 3 },
                new Chapter { Id = 14, Name = "Subtraction", StandardId = 1, SubjectId = 3 },
                new Chapter { Id = 15, Name = "Multiplication", StandardId = 1, SubjectId = 3 },
                new Chapter { Id = 16, Name = "Division", StandardId = 1, SubjectId = 3 },
                new Chapter { Id = 17, Name = "Time", StandardId = 1, SubjectId = 3 },
                new Chapter { Id = 18, Name = "Money", StandardId = 1, SubjectId = 3 },

                new Chapter { Id = 19, Name = "Addition", StandardId = 2, SubjectId = 1 },
                new Chapter { Id = 20, Name = "Subtraction", StandardId = 2, SubjectId = 1 },
                new Chapter { Id = 21, Name = "Multiplication", StandardId = 2, SubjectId = 1 },
                new Chapter { Id = 22, Name = "Division", StandardId = 2, SubjectId = 1 },
                new Chapter { Id = 23, Name = "Time", StandardId = 2, SubjectId = 1 },
                new Chapter { Id = 24, Name = "Money", StandardId = 2, SubjectId = 1 },
                new Chapter { Id = 25, Name = "Addition", StandardId = 2, SubjectId = 2 },
                new Chapter { Id = 26, Name = "Subtraction", StandardId = 2, SubjectId = 2 },
                new Chapter { Id = 27, Name = "Multiplication", StandardId = 2, SubjectId = 2 },
                new Chapter { Id = 28, Name = "Division", StandardId = 2, SubjectId = 2 },
                new Chapter { Id = 29, Name = "Time", StandardId = 2, SubjectId = 2 },
                new Chapter { Id = 30, Name = "Money", StandardId = 2, SubjectId = 2 },
                new Chapter { Id = 31, Name = "Addition", StandardId = 2, SubjectId = 3 },
                new Chapter { Id = 32, Name = "Subtraction", StandardId = 2, SubjectId = 3 },
                new Chapter { Id = 33, Name = "Multiplication", StandardId = 2, SubjectId = 3 },
                new Chapter { Id = 34, Name = "Division", StandardId = 2, SubjectId = 3 },
                new Chapter { Id = 35, Name = "Time", StandardId = 2, SubjectId = 3 },
                new Chapter { Id = 36, Name = "Money", StandardId = 2, SubjectId = 3 },

                new Chapter { Id = 37, Name = "Addition", StandardId = 3, SubjectId = 1 },
                new Chapter { Id = 38, Name = "Subtraction", StandardId = 3, SubjectId = 1 },
                new Chapter { Id = 39, Name = "Multiplication", StandardId = 3, SubjectId = 1 },
                new Chapter { Id = 40, Name = "Division", StandardId = 3, SubjectId = 1 },
                new Chapter { Id = 41, Name = "Time", StandardId = 3, SubjectId = 1 },
                new Chapter { Id = 42, Name = "Money", StandardId = 3, SubjectId = 1 },
                new Chapter { Id = 43, Name = "Addition", StandardId = 3, SubjectId = 2 },
                new Chapter { Id = 44, Name = "Subtraction", StandardId = 3, SubjectId = 2 },
                new Chapter { Id = 45, Name = "Multiplication", StandardId = 3, SubjectId = 2 },
                new Chapter { Id = 46, Name = "Division", StandardId = 3, SubjectId = 2 },
                new Chapter { Id = 47, Name = "Time", StandardId = 3, SubjectId = 2 },
                new Chapter { Id = 48, Name = "Money", StandardId = 3, SubjectId = 2 },
                new Chapter { Id = 49, Name = "Addition", StandardId = 3, SubjectId = 3 },
                new Chapter { Id = 50, Name = "Subtraction", StandardId = 3, SubjectId = 3 },
                new Chapter { Id = 51, Name = "Multiplication", StandardId = 3, SubjectId = 3 },
                new Chapter { Id = 52, Name = "Division", StandardId = 3, SubjectId = 3 },
                new Chapter { Id = 53, Name = "Time", StandardId = 3, SubjectId = 3 },
                new Chapter { Id = 54, Name = "Money", StandardId = 3, SubjectId = 3 }
            );
        }
    }
}
