using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Student : Person
    {
        private int _IqRank;
        private int _LanguageRank;
        private int age;
        public int IqRank
        {
            get { return _IqRank; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _IqRank = value;
                }
            }
        }
        public int LanguageRank
        {
            get { return _LanguageRank; }
            set
            {
                if (value <= 100 && value > 0)
                {
                    _LanguageRank = value;
                }
            }
        }
        protected override int _Age
        {
            get { return age; }
            set
            {
                if (value >= 6 && value <= 20)
                {
                    age = value;
                }
            }
        }

        public Student(string name, string surname, int age, int iqRank, int languageRank) : base(name, surname)
        {
            _Age = age;
            _IqRank = iqRank;
            _LanguageRank = languageRank;
        }

        public void ExamResult()
        {
            if (age >= 6 && age <= 20 && LanguageRank <= 100 && IqRank <= 100 && (LanguageRank + IqRank >= 120))
            {
                Console.WriteLine("passed with " + (LanguageRank + IqRank + " points"));
            }
            else if (age < 6 || age > 20)
            {
                Console.WriteLine("Your age is not appropriate ");
            }
            else if(LanguageRank>100 || LanguageRank<0 || IqRank > 100 || IqRank < 0)
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                Console.WriteLine("Failed  :(");
            }
        }

    }
}
