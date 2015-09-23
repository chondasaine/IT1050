

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person.Count++;

            Spouse spouse1 = new Spouse();
            Spouse spouse2 = new Spouse();
            Spouse spouse3 = new Spouse();
            Spouse.Count++;

            System.Console.WriteLine("Person 1#:" + " " + person1.GetFullName() + "Person #1:" + " " + person1.GetAge() + "Person #1:" + person1.GetMaritalStatus());
            
            if (person1.MaritalStatus == true)
            {
                System.Console.WriteLine(spouse1.GetSpouseNameAndAge()); 
            }

            System.Console.WriteLine(person2.GetFullName());
            System.Console.WriteLine(person2.GetAge());
            System.Console.WriteLine(person2.GetMaritalStatus());

            if (person2.MaritalStatus == true)
            {
                System.Console.WriteLine(spouse2.GetSpouseNameAndAge());
            }




            System.Console.WriteLine("The average age is = " + Person.GetAverageAge + ".");

        }
    }
 }  

