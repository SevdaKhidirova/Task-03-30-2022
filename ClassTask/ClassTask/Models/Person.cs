using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        protected abstract int _Age { get; set; }

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person()
        {

        }
    }
}
