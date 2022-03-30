using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_30_03_2022.Models
{
    /*Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
       Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
          Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək*/

    class Square:Figure
    {
        private double Side;
        /* public double Side { 
             get { return _Side; }
             set
             {
                 if (value > 0)
                 {
                     _Side = value;
                 }
                else
                 {
                     _Side = 0;
                     Console.WriteLine("set oluna bilmir");
                 }
             }
         }*/
        public Square(double side)
        {
            if (side > 0)
            {
                Side = side;
            }
            else Console.WriteLine("The side can't be negative");
        }

        public override void CalcArea()
        {
            if (Side > 0)
            {
                Console.WriteLine("The area of square is ---->" + Side * Side);
            }  
        }
    }
}
