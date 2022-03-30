using ClassTask.Models;
using System;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jim", "Coffe", 19, 10, 100);
            employee.CalculateSalary();

            Student student = new Student("Con", "Smith", 30, 100, 100);
            student.ExamResult();
        }
    }
}
