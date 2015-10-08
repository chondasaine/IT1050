
namespace Assignment_3
{
    class Student
    {
        private string StudentName;
        private int Grade;
        private Instructor Name;


        public Student(string StudentName, Instructor Name, int Grade)
        {
            this.StudentName = StudentName;
            this.Name = Name;
            this.Grade = Grade;
        }
        public int SetGrade(int Grade)
        {
            return Grade;
        }
        public void PrintStudentInfor()
        {
            string output = this.StudentName;
            output += " ";
            output += this.Grade;
            output += " ";
            output += this.Name;
            System.Console.WriteLine(output);
            System.Console.ReadKey();
        }
    }
}
