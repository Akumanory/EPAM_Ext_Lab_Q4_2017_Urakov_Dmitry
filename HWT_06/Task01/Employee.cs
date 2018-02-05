namespace Task01
{
    using System;

    public class Employee : User
    {
        private DateTime workExperience;
        private string position;

        public DateTime WorkExperience//todo pn где проверка, что возраст не меньше, чем опыт работы?
        {
            get
            {
                return workExperience;
            }

            set
            { 
                    workExperience = value;
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
