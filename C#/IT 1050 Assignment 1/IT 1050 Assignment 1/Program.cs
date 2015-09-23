using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // variable declaration
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            double heightInches;
            double totalHeightCM;
            double heightFeet;
            const double centimenters = 2.54;
            const double inches = 12;        

            
            System.Console.WriteLine("What is your first name?");
            firstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your middle initial?");
            middleInitial = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name?");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(fullName = firstName + " " + middleInitial + "." + " " + lastName + ".");

            System.Console.WriteLine("How many feet tall are you");
            heightFeet = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many inches tall are you");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (heightFeet * inches + heightInches) * (centimenters);
            System.Console.WriteLine("Your Height in CM:" +  totalHeightCM);

            System.Console.WriteLine("Please enter your age");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Are you a US Citizen? Please enter true or false");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = (isCitizen == true) && (age > 18);
            System.Console.WriteLine(canVote.ToString());

            System.Console.WriteLine(fullName + totalHeightCM + canVote);
            


        }
    }
}
