using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number !");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            // teen siia if ja else loogikaga vastused


            Console.ReadKey();

            {
                if (numberParsed <= 50)

                    Console.WriteLine("See nr on võrdne või väiksem 50-st");

                else

                {
                    Console.WriteLine("Kõik ülejäänud numbrid.");
                }
            }
        }



    }
}

