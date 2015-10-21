
namespace Assignment3_REV
{
    class Instructor
    {
        private string Teacher;
         private string CourseName;



        public string GetTeacherName(string Teacher)
        {
            return Teacher;
        }
        public Instructor(string Teacher, string CourseName)
         {
            
            this.Teacher = Teacher;
            this.CourseName = CourseName; 
         } 
 
 
        public void SetStudentGrade(Student Student, int Grade)
         { 
             Student.StudentSetGrade(Grade); 
         }


        public void PrintInstructorInfor()
         { 
             string output = this.Teacher; 
             output += " "; 
             output += this.CourseName; 
             System.Console.WriteLine(output); 
             System.Console.ReadKey(); 
 
  
 
        } 
    } 
 
 
 
 
 } 
