

namespace Assignment_2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public bool MaritalStatus;
        public double PersonAge;
        public static int Count;
        


        public void GatherPersonDetails()
        {
            this.FirstName = Question.AskForString("What is your first name?");
            this.LastName = Question.AskForString("What is your last name?");
            this.Age = Question.AskForInteger("How old are you?");
            this.MaritalStatus = Question.AskForBool("Are you married? Please enter: true or false");
        }

         public string GetFullName()
        {
            return this.FirstName + this.LastName;
        }

        public int GetAge()
        {
            return this.Age;
        }
        public bool GetMaritalStatus()
        {
            return this.MaritalStatus;
        }

        public double GetPersonAge()
        {


            double Age = 0;

            Age += this.Age;

      
                return PersonAge;
            }
                
          } 
                 
         }

        