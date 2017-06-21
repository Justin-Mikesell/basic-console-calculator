using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

                
                    
                // while this is true the app will continue to run
                bool appRunning = true;

                // Displays the opening menu, prompts user to continue and tells them how to end program 
               
                Menu.DisplayMenu();
                string userInput = Console.ReadLine();
                Console.Clear();
                if (userInput.ToLower() == "quit")
                {
                    appRunning = false;
                }


            while (appRunning)
            {
                try
                {


                    InputConverter inputConverter = new InputConverter();
                    CalculatorOperation calculatorEngine = new CalculatorOperation();

                    Console.WriteLine("Enter your first number: ");
                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    // Will end program
                    if (firstNumber.ToString().ToLower() == "quit")
                    {
                        appRunning = false;
                    }
                    Console.Clear();

                    // Allows the user to choose what operation to input
                    Console.WriteLine("Enter the operation. You can type +, -, *, / or add, subtract, multiply, divide: ");
                    string operation = Console.ReadLine();

                    // Will end program 
                    if (operation.ToLower() == "quit")
                    {
                        appRunning = false;
                        break;
                    }
                    Console.Clear();

                    Console.WriteLine("Enter your second number: ");
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                    // Will end program
                    if (secondNumber.ToString().ToLower() == "quit")
                    {
                        appRunning = false;
                    }

                    // Uses a switch statement to decide on what operation to perform on the users input numbers
                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                    Console.Clear();
                    Console.WriteLine("{0} {1} {2} = {3}" + "\n", firstNumber, operation, secondNumber, result);
                }


                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again. Press Enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
    }
}
