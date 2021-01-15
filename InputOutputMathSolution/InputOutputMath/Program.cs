using System;

namespace InputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implement a temparature converter from
             * Celsius to Fahrehiet
             * 
             * Jan 2021
             */

            //input: Celsius temparature
            //       string inputTemp
            //       double theCelsius temparature

            //output: Fahrehiet temparature 
            //       double theFahrahiet temparature

            //expression (calculate):  (ct * 9.0/5.0)) + 32
            //check with ct = 0 expect ft = 32
            //check with ct = 100 expect ft = 112
            //check with ct = -40 expect ft = -40

            //prompt for a celsius temparature 
            // .Write() keeps your cursor on the same line 
            Console.Write("Enter a Celsius temparature: ");
            //how does the program pull in the entry from the user
            //to obtain the key stokes that user type (input)
            // .Readline();
            //important!!
            // data comes into the program as a string
            // DOES NOT matter if you enter a number, it is treat as
            //                a string

            //declare the variable:       datatyle variablename;    

            string inputTemp;
            //assignment statement:       expression on the right is placed
            //                            into the variable on the left
            //expression (action):        read the user input
            inputTemp = Console.ReadLine();

            //you could do both statements on the line
            // string inputTemp = Console.Readline();

            //currently the celsius value is a string
            //the value needs to be converted to a number to be
            //       used in a math calculation
            //convert the date to a different datatype
            //to do this; you will use technique called parsing
            //  syntax:  datetypeTo.Parse(string value)


            //WARNING: I am assuming the user will enter valid data
            //         If the users does not enter a number, this program
            //         will abort on the execution of this line

            double theCelsiusTemparature = double.Parse(inputTemp);

            //calculation using the conversion expession 
            double theFahrenhietTemparature = (theCelsiusTemparature * (9.0 / 5.0)) + 32;

            //output
            // .WirteLine() Which automaticaly goes to the next line.
            Console.WriteLine($"The Celsius Temparature of {theCelsiusTemparature} is {theFahrenhietTemparature} in Fahrehiet.");

                   


        }
    }
}
