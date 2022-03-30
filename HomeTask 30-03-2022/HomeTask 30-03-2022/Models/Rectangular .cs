using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_30_03_2022.Models
{
    /*Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
     Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
     Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.*/

    class Rectangular : Figure
    {
        private double Width;
        private double Height;

        /* public double Width
         {
             get { return _Width; }
             set
             {
                 if (value > 0)
                 {
                     _Width = value;
                 }
                else
                {
                    _Width = 0;
                    Console.WriteLine("set oluna bilmir");
                }
             }
         }*/

        /*  public double Height
          {
              get { return _Height; }
              set
              {
                  if (value > 0)
                  {
                      _Height = value;
                  }
                 else
                  {
                      _Height = 0;
                      Console.WriteLine("set oluna bilmir");
                  }
              }
          }*/

        public Rectangular(double width, double height)
        {
            if(width>0 && height > 0)
            {
                Width = width;
                Height = height;
            }
            else Console.WriteLine("The side can't be negative");
        }

        public override void CalcArea()
        {
            if(Width>0 && Height > 0)
            {
                Console.WriteLine("The are of rectangular is -->" + (Width * Height));
            }
        }
    }
}
