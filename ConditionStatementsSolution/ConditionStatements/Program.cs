using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // const int MIN_NUMBER = 1;
            // const int MAX_NUMBER = 9;

            // Random keyrad = new Random();

            //int number1 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);
            //int number2 = keyrad.Next(MIN_NUMBER, MAX_NUMBER + 1);

            //Console.Write($"The sum of {number1} + {number2} = ?\t");

            //String inputTemp = Console.ReadLine();
            //int answer = int.Parse(inputTemp);
            //int answer = int.Parse(Console.ReadLine());

            //The conditional test is ( number1 + number2) == answer
            //where the left argument is (number1 + number2)
            //      the relational operator is == (equals)
            //      the right argument is answer
            //      the condittion will resolve ture or false 
            //Console.WriteLine($"{number1} + {number2} = {answer} Your answer is {(number1 + number2) == answer}");

            //the one way if statement
            //double radius = 4.5;
            // if (radius > 0)
            // {
            //    double area = Math.Pow(radius, Math.PI);
            //    if (area >= 100.0)
            //   {
            //       Console.WriteLine($"The are of a circle with a radius of {radius} is {Math.Round(area, 2)}. Your circle is large enough. ");
            //    }
            //    else
            //    {
            //       Console.WriteLine($"The are of a circle with a radius of {radius} is {Math.Round(area, 2)}. Increase the size of the radius");
            //    }
            //    
            // }

            //A two-way if statement 
            //has a true path and a false path
            //the ture

            int FahrenheitTemperature = 100;
            int CelsiusTemperature = 0;

            CelsiusTemperature = (FahrenheitTemperature - 32) * (5 / 9);

            if (CelsiusTemperature < 0)
            {
                Console.WriteLine("It is freezing out!");
            }
            else if(CelsiusTemperature < 15)
            {
                Console.WriteLine("Wear a jacket");
            }
            else if(CelsiusTemperature < 30)
            {
                Console.WriteLine("It is a loving day");
            }
            else
            {
                Console.WriteLine("It is finally summer");
            }
            


            


        }
    }
}
