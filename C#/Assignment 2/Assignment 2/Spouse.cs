

namespace Assignment_2
{
    class Spouse
    {
        public int SpouseAge;
        public string SpouseFirstName;
        public double SpouseTotalAge;
        public static int Count;


        public void GatherSpouseDetails()
        {
            this.SpouseFirstName = Question.AskForString("What is your spouse's first name?");
            this.SpouseAge = Question.AskForInteger("What is your spouse's age");

        }

        public string GetSpouseNameAndAge()
        {
            return this.SpouseFirstName + this.SpouseAge;
        }

        public double GetSpouseTotalAge()
        {


            double Age = 0;

            Age += this.SpouseAge;


            return SpouseTotalAge;
        }
    }
}
