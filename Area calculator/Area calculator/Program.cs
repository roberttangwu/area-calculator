// this is show which ibraries i have pick to use
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// the is the name of the program
namespace Area_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            area myCalc = new area();
            // all this is variable name
            double inputOne = 0;
            double inputTwo = 0;
            double radius = 0;
            int opChoice = 0;
            // this is about the welcome the user to use this application
            Console.WriteLine("############################################################");
            Console.WriteLine("############# C#  A R E A  C A L C U L A T O R #############");
            Console.WriteLine("############################################################");
            //put the loop to make the application to keep running
            bool calcLoop = true;
            while (calcLoop == true)
            {
                // this is about the help file for the user to know how to use this application
                Console.WriteLine("Would you like to view our help tutorial before using the calculator Y/N? ");
                //this is the question to ask the user to view the help file or not
                string helpfile = Console.ReadLine().ToLower();
                switch (helpfile)
                {
                    
                   //when the user put yes or y will open the helpfile 
                    case "yes":
                        Console.WriteLine("Enter the shape you would like to use");
                        Console.WriteLine("Enter your first number");
                        Console.WriteLine("Enter your second number");
                        Console.WriteLine("Or enter your radius number");
                        Console.WriteLine("View your result");
                        Console.WriteLine("Choose do you want to continue to use the calculator");
                        
                        break;
                    case "y":
                        Console.WriteLine("Enter the shape you would like to use");
                        Console.WriteLine("Enter your first number");
                        Console.WriteLine("Enter your second number");
                        Console.WriteLine("Or enter your radius number");
                        Console.WriteLine("View your result");
                        Console.WriteLine("Choose do you want to continue to use the calculator");
                        break;
                }



                // this is ask the user to pick the shape
                bool numberone = false;
                while (numberone == false)
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("Enter 1 for rectangle");
                    Console.WriteLine("Enter 2 for triangle");
                    Console.WriteLine("Enter 3 for circle");

                    
                    string inputString = Console.ReadLine();

                    // this loop for the user need to put digit number to pick the shape if not will keep ask the user to put digit number

                    bool parsed = int.TryParse(inputString, out opChoice);
                    if (!parsed)
                    {
                        Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);
                    }
                    else if(opChoice >= 4| opChoice <= 0)
                    {
                        Console.WriteLine("Please select a vaild chicoe");
                    }
                    else
                    {
                        numberone = true;
                    }

                }






                // this is make sure the computer pick the right function to run
                    switch (opChoice)
                    {

                    // when the user pick rectangle will run this function
                    case 1:
                            bool numberOne = false;
                            while (numberOne == false)
                            {
                            //ask the user to input first number
                                Console.Write("Enter your first number: ");
                                string inputString = Console.ReadLine();


                            // the loop is make sure the user is put digit number on it not the text
                                bool parsed = double.TryParse(inputString, out inputOne);
                                if (!parsed)
                                {
                                    Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);
                                }
                                else
                                {
                                    numberOne = true;
                                }
                            }
                            bool numberTwo = false;
                            while (numberTwo == false)
                            {
                            //ask the user to input second number
                                Console.Write("Enter your second number: ");
                                string inputString = Console.ReadLine();


                            // the loop is make sure the user is put digit number on it not the text
                                bool parsed = double.TryParse(inputString, out inputTwo);
                                if (!parsed)
                                {
                                    Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);
                                }
                                else
                                {
                                    numberTwo = true;
                                }


                            }
                            Console.WriteLine("\nYour answer is: " + (inputOne * inputTwo).ToString("F") + "m2");
                            break;
                    // when the user pick triangle will run this function
                        case 2:
                            bool numberOne1 = false;
                            while (numberOne1 == false)
                            {
                            //ask the user to input first number
                                Console.Write("Enter your first number: ");
                                string inputString = Console.ReadLine();


                            // the loop is make sure the user is put digit number on it not the text
                                bool parsed = double.TryParse(inputString, out inputOne);
                                if (!parsed)
                                {
                                    Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);
                                }
                                else
                                {
                                    numberOne1 = true;
                                }
                            }
                            bool numberTwo1 = false;
                            while (numberTwo1 == false)
                            {
                            //ask the user to input second number
                                Console.Write("Enter your second number: ");
                                string inputString = Console.ReadLine();


                            // the loop is make sure the user is put digit number on it not the text
                                bool parsed = double.TryParse(inputString, out inputTwo);
                                if (!parsed)
                                {
                                    Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);
                                }
                                else
                                {
                                    numberTwo1 = true;
                                }


                            }
                            Console.WriteLine("\nYour answer is: " + (inputOne * inputTwo / 2).ToString("F") + "m2");
                            break;
                    // when the user pick circle will run this function
                        case 3:
                            bool numberRadius = false;
                            while (numberRadius == false)
                            {
                            //ask the user to input radius number
                                Console.Write("Enter your radius number: ");
                                string inputString = Console.ReadLine();
                            // the loop is make sure the user is put digit number on it not the text
                                bool parsed = double.TryParse(inputString, out radius);
                                if (!parsed)
                                {
                                    Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);
                                }
                                else
                                {
                                    numberRadius = true;
                                }
                            }
                            Console.WriteLine("\nYour answer is: " + (radius * radius * 3.14).ToString("F") + "m2");
                            break;
                        // when the user dosen't pick 1-3 will tell the user to restart the program
                        default:
                            Console.WriteLine("\nYou should enter a number from the menu. ");
                            break;

                    }
                 // ask the user want to continue to use program or not  
                Console.WriteLine("");
                Console.Write("\nDo you want to continue with this calculator? Y/N: ");
                string restartChoice = Console.ReadLine().ToUpper();
                // when the user put yes the code will restart 
                if (restartChoice == "Y")
                {
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();

                }
                else if (restartChoice == "YES")
                {
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();

                }
                // when the user put diiferent thing the code will be stop
                else
                {
                    Console.WriteLine("press any key to exit");
                    calcLoop = false;

                }
                Console.ReadKey();
            }
        
        }

        
    }
}
