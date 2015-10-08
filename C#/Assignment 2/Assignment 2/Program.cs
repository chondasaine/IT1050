

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.GatherPersonDetails();
            Person.Count++;
           
            System.Console.WriteLine("Person 1#:" + " " + person1.GetFullName() + "Person #1:" + " " + person1.GetAge() + "Person #1:" + person1.IsMarried());

            if (person1.IsMarried() == true)
            {
                
            Person personspouse1 = new Person();
            personspouse1.GetSpouseNameAndAge();
            Person.Count++;
            System.Console.WriteLine("Person 1#:" + " " + personspouse1.FirstName + " " + personspouse1.Age); 

            }

            Person person2 = new Person();
            person2.GatherPersonDetails();
            Person.Count++;

            System.Console.WriteLine("Person 2#:" + " " + person2.GetFullName() + "Person #2:" + " " + person2.GetAge() + "Person #2:" + person2.IsMarried());

            if (person2.IsMarried() == true)
            {

                Person personspouse2 = new Person();
                personspouse2.GetSpouseNameAndAge();
                Person.Count++;
                System.Console.WriteLine("Person 2#:" + " " + personspouse2.FirstName + " " + personspouse2.Age);

            }

            Person person3 = new Person();
            person3.GatherPersonDetails();
            Person.Count++;

            System.Console.WriteLine("Person 3#:" + " " + person3.GetFullName() + "Person #3:" + " " + person3.GetAge() + "Person #3:" + person3.IsMarried());

            if (person3.IsMarried() == true)
            {

                Person personspouse3 = new Person();
                personspouse3.GetSpouseNameAndAge();
                Person.Count++;
                System.Console.WriteLine("Person 3#:" + " " + personspouse3.FirstName + " " + personspouse3.Age);

            }

           double.Parse(System.Console.WriteLine("Average Age:" + GetAverageAge()));


        }
    }
 }  

