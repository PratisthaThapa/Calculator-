using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        public static string TakeFirstInput()
        {

            Console.WriteLine("Enter your first value");
            var firstInput = Console.ReadLine();

            return firstInput;
        }


        public static string TakeSecondInput()
        {

            Console.WriteLine("Enter your second value");
            var secondInput = Console.ReadLine();

            return secondInput;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();


                var firstInput = TakeFirstInput();
            var secondInput = TakeSecondInput();
            
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    if (int.TryParse(firstInput, out int addNumOne) && int.TryParse(secondInput, out int addNumTwo))
                    {
                        Console.Write($"{firstInput} + {secondInput} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    if (int.TryParse(firstInput, out int subNumOne) && int.TryParse(secondInput, out int subNumTwo))
                    {
                        Console.Write($"{firstInput} - {secondInput} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                  

                    Console.WriteLine(firstInput + " is your number 1");
                    Console.WriteLine(secondInput + "is your number 2");

                    if (int.TryParse(firstInput, out int mulNumOne) && int.TryParse(secondInput, out int mulNumTwo))
                    {
                        Console.Write($"{firstInput} * {secondInput} = ");
                        Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;


                case "4":
                 

                    if (double.TryParse(firstInput, out double divNumOne) && double.TryParse(secondInput, out double divNumTwo))
                    {
                        Console.Write($"{firstInput} / {secondInput} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }





    }
}