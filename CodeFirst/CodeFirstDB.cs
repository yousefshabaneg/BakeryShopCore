using System.Data.Entity;

namespace CodeFirst
{
    class CodeFirstDB : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }

    class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
    }
}
