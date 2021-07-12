using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CodeFirstDB();
            Student std = new Student
            {
                StudentID = 1,
                FullName = "Yousef Shaban",
                Age = 22,
                Salary=3500
            };
            db.Students.Add(std);
            db.SaveChanges();
        }
    }
}
