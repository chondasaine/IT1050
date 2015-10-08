namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");
            Student Jane = new Student("Jane", John , 0);
            Student Joe = new Student("Joe", John, 0);
            Student Melissa = new Student("Melissa", Mike, 0);
            Student Matt = new Student("Matt", Mike, 0);

            Jane.SetGrade(95);
            Joe.SetGrade(85);
            Melissa.SetGrade(90);
            Matt.SetGrade(92);

            John.SetStudentGrade("Jane", 95 );
            John.SetStudentGrade("Joe", 85);
            Mike.SetStudentGrade("Melissa", 90);
            Mike.SetStudentGrade("Matt", 92);

            Jane.PrintStudentInfor();
            Joe.PrintStudentInfor();
            Melissa.PrintStudentInfor();
            Matt.PrintStudentInfor();

        }
    }
}
