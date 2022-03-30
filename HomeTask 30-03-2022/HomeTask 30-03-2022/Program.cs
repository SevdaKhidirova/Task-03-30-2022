using HomeTask_30_03_2022.Models;
using System;

namespace HomeTask_30_03_2022
{
    class Program
    {
        /*Program class-ında bir menu olacaq
          1. Square
          2. Rectangular
          0. Quit

          İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
          İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
          İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdır.*/

        static void Main(string[] args)
        {
            
            
            Console.WriteLine("0.quit\n1.Square \n2.Rectangular ");

           

            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                while (input >= 0 && input < 3)
                {

                    if (input == 1)// switch le da yazmaq olar
                    {
                        
                        Console.WriteLine("Pls enter side of square");
                        double squareSide = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square(squareSide);
                        square.CalcArea();
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("pls enter width of rectangular");
                        double recWidth = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("and enter height of rectangular");
                        double recHeight = Convert.ToDouble(Console.ReadLine());
                        Rectangular rec = new Rectangular(recWidth, recHeight);
                        rec.CalcArea();
                    }
                    else if (input == 0)
                    {
                        break;
                    }
                    input = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch (Exception)
            {

                Console.WriteLine("something wents wrong :)");
            }


        }
    }
}
