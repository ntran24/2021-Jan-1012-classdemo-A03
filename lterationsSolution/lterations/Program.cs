using System;

namespace lterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //pre-test loop (a.k.a.  DO-While Structure)
            // 
            string inputTemp;
            int aNumber;

            Console.Write("Enter a number:\t");
            inputTemp = Console.ReadLine();
            aNumber = int.Parse(inputTemp);
            int loopExecutions = 0;
            // pre-test loop
            do
            {
                //all code within this coding block ({....})
                // belongs to the loop

                //a fast way of adding 1 to a counter
                loopExecutions++;
                Console.WriteLine($"You entered the number {aNumber}");
                Console.Write("Enter a number:\t");
                inputTemp = Console.ReadLine();
                aNumber = int.Parse(inputTemp);
                if(aNumber != 0)
                {
                    Console.WriteLine($"You entered the number");
                }

            } while (aNumber != 0);

            //next statement is the 1st executable statment after the loop
            Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions}");

        }
    }
}
