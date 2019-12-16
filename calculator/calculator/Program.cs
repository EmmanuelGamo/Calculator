using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart = "no";
            decimal Num1;
            decimal Num2;
         
            do
            {
                Console.WriteLine("Input First Number:");
                string x = Console.ReadLine();

                while (decimal.TryParse(x, out decimal n) == false)
                {
                    Console.WriteLine("Please put a valid number");
                    x = Console.ReadLine();
                }
                Num1 = decimal.Parse(x);
                Console.WriteLine("Input Second Number:");
                x = Console.ReadLine();
                while (decimal.TryParse(x, out decimal n) == false)
                {
                    Console.WriteLine("Please put a valid number");
                    x = Console.ReadLine();
                }
                Num2 = decimal.Parse(x);
                Console.WriteLine("Choose an operation you want to use (+,-,*,/)");
                string Operation = Console.ReadLine();
                while (true)
                {
              
                    if (Operation == "+")
                    {
                        Console.WriteLine("The answer is:" + (Num1 + Num2));
                        Console.WriteLine("Type 'yes' to calculate again");
                        restart = Console.ReadLine();
                        break;


                    }
                    else if (Operation == "-")
                    {
                        Console.WriteLine("The answer is:" + (Num1 - Num2));
                        Console.WriteLine("Type 'yes' to calculate again");
                        restart = Console.ReadLine();
                        break;


                    }
                    else if (Operation == "*")
                    {
                        Console.WriteLine("The answer is:" + (Num1 * Num2));
                        Console.WriteLine("Type 'yes' to calculate again"); ;
                        restart = Console.ReadLine();
                        break;

                    }
                    else if (Operation == "/")
                    {
                        Console.WriteLine("The answer is:" + (Num1 / Num2));
                        Console.WriteLine("Type 'yes' to calculate again");
                        restart = Console.ReadLine();
                        break;
                    }
                    else

                    {
                        Console.WriteLine("Please choose a valid operation!");
                        Operation = Console.ReadLine();
                    }

                }

            } 
             while (restart == "yes");
            



            Environment.Exit(0);
            




        }


    }
}
