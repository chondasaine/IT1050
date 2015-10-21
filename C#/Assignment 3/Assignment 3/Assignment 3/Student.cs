
namespace Assignment3_REV
{
    class Student
    {
        private string StudentName;
        private int Grade;
        private Instructor Teacher;

       

        public Student(string StudentName, Instructor Teacher)
        {
            this.StudentName = StudentName;
            this.Teacher = Teacher;
            this.Grade = 0;
        }
       
        public void StudentSetGrade( int grade)
        {
            this.Grade = grade;
        }

        public void PrintStudentInfor()
        {
            string output = this.StudentName;
            output += " ";
            output += this.Grade;
            output += " ";
            output += this.Teacher;
            System.Console.WriteLine(output);
            System.Console.ReadKey();
        }
