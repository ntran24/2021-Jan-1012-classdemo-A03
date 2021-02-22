using System;

namespace IterationPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            // string inputTemp;
            //Find The sum of the squares of the intergers from 1 to MySquare, where MySquare  is input by
            // the user.E.g.user Enters 4 then return 1x1 + 2x2  + 3x3 + 4x4 = 30

            // int mySquare = 0;
            //int sumOfSquares = 0;

            //  Console.Write($"Enter a number and find out its sum of squares\t");
            // inputTemp = Console.ReadLine();
            //
            //Validate the incoming value
            //
            //xxx.tryParse Take the input string and attempts to convert the string
            //    to the request numeric datatype
            //if the attempt is good then the value is placed in the out variable & the true is returned
            //if the attempt fails then a false is returned & NO conversion is done

            //  if(int.TryParse(inputTemp, out mySquare))
            // {

            // if (mySquare > 0)
            //  {
            //one needs to do the iteration at least once, seems a good canadidate for post-loop
            // int LoopCount = 1;
            //  do
            //  {
            //  sumOfSquares += LoopCount * LoopCount;
            //sumOfSquares += sumOfSquares + LoopCount * LoopCount;
            //sumOfSquares += (int)Math.Pow(LoopCount, 2);

            //you must increment your loop  counter  
            //       LoopCount++;

            //        } while (LoopCount <= mySquare);
            //        Console.WriteLine($"The sum of squares for {mySquare} is  {sumOfSquares}");
            //     }
            //     else
            //   {
            //         Console.WriteLine($"{mySquare} is invalid. Enter a positive greateer than 0 number. ");
            //   }

            //  }
            // else
            // {
            //  Console.WriteLine($"{inputTemp} is invalid. Enter a number. ");
            // }

            decimal myPrincipal = 0.0m;
            decimal myMonthlyInterestRate = 0.0m;
            Int32 myInvestmentTime = 0;
            string inputTemp;


            string menuChoice = "";

            do
            {
                Console.WriteLine("Welcome to CPSC Investment:\n\n");
                Console.WriteLine("a) investment: ");
                Console.WriteLine("x) to exit\n");
                Console.Write("Enter your menu choice");
                menuChoice = Console.ReadLine();

                switch(menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //for this example, I will assume valid data is entered 
                            Console.WriteLine("\nEnter your principal investment amount:\t");
                            inputTemp = Console.ReadLine();
                            myPrincipal = decimal.Parse(inputTemp);
                            Console.WriteLine("\nEnter your principal investment monthly rate (3% -> 0.03):\t");
                            inputTemp = Console.ReadLine();
                            myMonthlyInterestRate = decimal.Parse(inputTemp);
                            Console.WriteLine("\nEnter your principal investment period in months:\t");
                            inputTemp = Console.ReadLine();
                            myInvestmentTime = Int32.Parse(inputTemp);
                            //use a loop for a fix amount of iterations
                            //best condition would be a pre-test loop
                            // a) while with a counter
                            // b) for (...) loop
                            for (int counter = 0; counter < myInvestmentTime; counter++)
                            {





                            }
                            break;
                        
                }
                    case "x":
                        {
                            Console.WriteLine("\n Thank you. Good-Bye. \n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYou entry for the menu choice is invalid. Try again.\n");
                            break;
                        }

                }


            } while (menuChoice.ToLower() != "x");
            string msg = "Good luck on your future investments";
            for(int i = 0; i < msg.Length; i++)
                ¨¨





        }
    }
}
