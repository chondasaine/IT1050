
namespace Assignment_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public string SetStudentGrade(string Student, int Grade)
        {
            return Student + " " + Grade;
        }
        public void PrintInstructorInfor()
        {
            string output = this.Name;
            output += " ";
            output += this.CourseName;
            System.Console.WriteLine(output);
            System.Console.ReadKey();


        }
    }


}
