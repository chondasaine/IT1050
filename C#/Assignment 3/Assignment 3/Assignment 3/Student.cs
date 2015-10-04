
namespace Assignment_3
{
    class Student
    {
        private string StudentFirstName;
        private string StudentLastName;
        private int Grade;
        private Instructor Teacher;


        public Student(string StudentFirstName, string StudentLastName, string InstructorTeacher, int Grade)
        {
            this.StudentFirstName = StudentFirstName;
            this.StudentLastName = StudentLastName;
            this.Teacher = Instructor;
            this.Grade = 0;
        }
        public int SetGrade(int Grade)
        {
            return Grade;
        }
        public void PrintStudentInfor()
        {
            string output = this.StudentFirstName;
            output += " ";
            output += this.StudentLastName;
            output += " ";
            output += this.Grade;
            output += " ";
            output += this.Teacher;
            System.Console.WriteLine(output);
            System.Console.ReadKey();
        }
}
