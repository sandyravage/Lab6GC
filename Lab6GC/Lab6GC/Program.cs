using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();
            Roller();
        }

        private static void Initialize()
        {
            
            Console.WriteLine("Welcome to the Grand Circus Casino! \n");

            while (true)
            {
                Console.Write("\nRoll em? (y/n): ");
                string Continue = Console.ReadLine();
                if (Continue != "y" && Continue != "n")
                {
                    Console.WriteLine("\nSorry, input not recognized. Please try again. \n");
                    continue;
                }
                else if(Continue == "y")
                {
                    break;
                }
                else if (Continue == "n")
                {
                    Environment.Exit(0);
                }
            }
            
        }

        private static void Roller()
        {
            Console.Write("\nCool, happy you're here today. How many sides are the dice you will be rolling?: ");

            int sides;
            int count = 0;

            while (true)
            {
                bool res = int.TryParse(Console.ReadLine(), out sides);
                if (res)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nI'm sorry, this input was not recognized. Please try again. \n");
                    continue;
                }
            }

            Random rollem = new Random();

            while (true)
            {
                count++;
                Console.WriteLine("\nRoll " + count + "\n");
                Console.WriteLine(rollem.Next(1, sides + 1));
                Console.WriteLine(rollem.Next(1, sides + 1) + "\n");

                while(true)
                {
                    Console.Write("\nRoll again? (y/n): ");
                    string Continue = Console.ReadLine();

                    if (Continue != "y" && Continue != "n")
                    {
                        Console.WriteLine("\nSorry, input not recognized. Please try again. \n");
                        continue;
                    }
                    else if (Continue == "y")
                    {
                        break;
                    }
                    else if (Continue == "n")
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
