using System;
using System.Linq;
using System.Collections.Generic;

namespace SelectManyOperatorLinq
{
    class Program
    {
       	     static void Main()

        {
            var result =  from student in Student.GetAllStudents()
                          from subject in student.Subjects
                          select new { StudentName = student.Name, SubjectName = subject};

            foreach (var v in result)
            {
                Console.WriteLine(v.StudentName + " -" + v.SubjectName);
            }


        }
    }
    }

