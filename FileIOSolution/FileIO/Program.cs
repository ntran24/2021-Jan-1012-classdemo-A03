using System;

namespace FileIO
{
    class Program
    {

        // Main() is a methods
        // special method
        // enter point into your program execution

        static void Main(string[] args)
        {
            /*
             * process
             * 
             * this program will demonstrate methods, menu looping and various style of File I/O
             * 
             * create a post-loop (do/while) to handle the menu
             *       the menu will have 3 options, one for each type of File I/O style
             * 
             * menthods will be use to obtain the file name to be read for this program
             *          the method will have no incoming parameter, will return the string datatype
             *          
             * the reading and display of the file will be placed in the separate method
             *     the method will have a string incoming parameter,
             *     the method will not return anything(void datatype)
             *     the method demonstrate error handling using Try/Catch/Final
             *     
             */

            string inputTemp;

            //post loop structure, used 
            do
            {
                Console.WriteLine("File I/O options:");
                Console.WriteLine("a) Hard-Coded file name.");
                Console.WriteLine("b) Using Windows Environment (DeskTop, Documents, Download) path file name.");
                Console.WriteLine("c) Using Open-File dailog to obtain file name.");
                Console.WriteLine("x) Exit.\n");

                Console.Write("Enter the menu option for File I/O: ");
                inputTemp = Console.ReadLine();
                switch(inputTemp.ToUpper())
                {
                    case "A":
                        {
                            break;
                        }
                    case "B":
                        {
                            break;
                        }
                    case "C":
                        {
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank You, have a good one!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($" {inputTemp} is not a valid menu options. Try again.");
                            break;
                        }
                }

            } while (inputTemp.ToUpper() != "X");

           


        }
        /*  Methods
             *    
             * Why????
             *    reduce code redundancy
             *    break up your code into smaller managable pieces (modularization)
             *    
             * Where do methods go?
             *    methods go into your program class
             *    
             * Syntax for a method
             *    accesstype returndatype MethodName ([])
             *    {
             *       coding block
             *    }
             *    
             *    accesstype?
             *    this is dependant on what is the main access type or if the class is NOT the entry point to your entire application,
             *    could be public, private, internal,, protected....
             *    
             *    returndatatype
             *    Methods have been called by many names
             *    Methods have been called subroutines, functions, methods
             *    Subroutines and funtions are different in that subroutines return
             *         no data to the calling statement; whereas functions will return
             *         data to the calling statement.
             *    the return datatype must be a valid language datatype
             *    the return datatype in C#  that return nothing is the keyword void
             *         
             *    MethodName
             *    This is what the methods is called 
             *    The method name is usually unique   (
             *    the method names that are not unique are paired with list of
             *        parameter to create a method signature. The method signature
             *        MUST be unique. This is referred to as overload methods.
             *    
             *    [list of parameters]  (optional)
             *    What is a parameter?
             *    consider the parameter a variable within your methods that has already been declare and can we used as other variable
             *    datatype parametername 
             *    
             *    What is a list of parameter?
             *    datatype parametername, datatype parametername, .....
             *    
             */
        static string HardCodedFileName()
        {
            // setup a pathname to the folder on your machine that contain
            //    the  file to be read
            string Folder_Pathname = @"E:\GitHub\CPSC-1012\FileProcessing\";


            //concatenate a file name to the pathname 
            string full_path_filename;
            full_path_filename = Folder_Pathname + @"OneColumn.txt";

            //BECAUSE the methods indicate the returned datatype of string (anything
            //   but void), the method REQUIRES a return xxxx; statement

            return full_path_filename;

        }


    }
}
