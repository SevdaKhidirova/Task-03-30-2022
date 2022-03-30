using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Employee:Person
    {
        private double _SalaryPerHour;
        private int _WorkingHour;

        public double SalaryPerHour
        {
            get { return _SalaryPerHour; }
            set
            {
                if (value > 0)
                {
                    _SalaryPerHour = value;
                }
            }
        }
        public int WorkingHour
        {
            get { return _WorkingHour; }
            set
            {
                if (value > 8 && value < 240)
                {
                    _WorkingHour = value;
                }
            }
        }
        private int age;
        protected override int _Age { 
            get { return age; } 
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
            }
        }

        public Employee(string name,string surname ,int age,double salaryPerHour,int workingHour):base(name,surname)
        {
            _Age = age;
            _SalaryPerHour = salaryPerHour;
            _WorkingHour = workingHour;
        }

        public void CalculateSalary()
        {
            if (_Age >= 18 && (WorkingHour*SalaryPerHour>=250) )
            {

                Console.WriteLine("The salary of employee  -->"+ WorkingHour * SalaryPerHour);
            }
            else
            {
                Console.WriteLine(":(");
            }
        }
    }
}
