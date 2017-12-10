namespace Task03
{
    using System;

    public class User
    {
        private string surname;
        private string name;
        private string patronymic;
        private DateTime dateOfBorn;
        private int age;

        public string Surname
        {
            get
            {
                return surname; 
            }

            set
            {
                if (value != string.Empty)
                {
                    surname = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return name; 
            }

            set
            {
                if (value != string.Empty)
                {
                    name = value;
                }
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;     
            }

            set
            {
                if (value != string.Empty)
                {
                    patronymic = value;
                }
            }
        }

        public DateTime DateOfBorn
        {
            get
            {
                return dateOfBorn; 
            }

            set
            {
                dateOfBorn = value; 
            }
        }

        public int Age
        {
            get { return age; }
        }

        public void GetAgeByBirthDate()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dateOfBorn.Year;

            if (now.AddYears(-age) < dateOfBorn)
            {
                age--;
            }

            this.age = age;
        }
    }
}
