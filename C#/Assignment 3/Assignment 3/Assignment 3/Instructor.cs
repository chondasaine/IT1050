using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Instructor
    {
        private string FirstName;
        private string LastName;
        private string CourseName;

        public Instructor(string FirstName, string LastName,  string CourseName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CourseName = CourseName;
        }

        public string SetStudentGrade(string Student, int Grade)
        {
            return Student + " " + Grade;
        }
        public void PrintInstructorInfor()
        {
            string output = this.FirstName;
            output += " ";
            output += this.LastName;
            output += " ";
            output += this.CourseName;
            System.Console.WriteLine(output);
            System.Console.ReadKey();


        }
    }


}
