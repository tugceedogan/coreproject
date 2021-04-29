using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public static class Repository
    {
        private static List<Student> students = new List<Student>();

        public static List<Student> Students
        {
            get
            {
                return students;
            }

        }

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
