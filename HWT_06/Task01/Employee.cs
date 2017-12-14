namespace Task01
{
    public class Employee : User
    {
        private int workExperience;
        private string position;

        public int WorkExperience
        {
            get
            {
                return workExperience;
            }

            set
            {
                if (value >= 0)
                {
                    workExperience = value;
                }
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                if (value != string.Empty)
                {
                    position = value;
                }
            }
        } 
    }
}
