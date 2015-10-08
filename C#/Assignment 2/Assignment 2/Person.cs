

namespace Assignment_2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public bool MaritalStatus;
        public int PersonAge;
        public static double Count;
        public string SpouseFirstName;
        public int SpouseAge;




        public void GatherPersonDetails()
        {
            this.FirstName = Question.AskForString("What is your first name?");
            this.LastName = Question.AskForString("What is your last name?");
        }
        public string GetFullName()
        {
            return this.FirstName + this.LastName;
        }
        public void GetPersonAge()
        {
            this.Age = Question.AskForInteger("How old are you?");
        }

        public int GetAge()
        {
            return this.Age;

        }
        public void GetMaritalStatus()
        {

            this.MaritalStatus = Question.AskForBool("Are you married? Please enter: true or false");
        }

        public bool IsMarried()
        {
            return this.MaritalStatus;
        }
        public void GetSpouseNameAndAge()
        {
            this.SpouseFirstName = Question.AskForString("What is your spouse's first name?");
            this.SpouseAge = Question.AskForInteger("What is your spouse's age");
         }
        public int GetAverageAge()// should be static
        {
            int TotalAge = 0;

            TotalAge += Age;
            TotalAge += SpouseAge;
            double AverageAge = (TotalAge/Count);

            return AverageAge;

           }
        }
     }
   
    
                 
         

        