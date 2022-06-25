using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyOperatorLinq
{
    class Student
    {
        public string Name { get; set; }
        public string Gneder { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>
            {
                new Student
                {
                    Name = "Tom",
                    Gneder = "Male",
                    Subjects = new List<string> { "ASP.NET", "C#" }
                },
                new Student
                {
                    Name = "Mike",
                    Gneder = "Male",
                    Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
                },
                new Student
                {
                    Name = "Pam",
                    Gneder = "Female",
                    Subjects = new List<string> { "WCF", "SQL Server", "C#" }
                },
                new Student
                {
                    Name = "Mary",
                    Gneder = "Female",
                    Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
                },

            };
            return listStudents;
        }
    }
}

    

