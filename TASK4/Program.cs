using System;

namespace TASK4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that cheks whether a given number is negative or positive

               int Number;*/

            int Number;
            string UserInput;

            Console.WriteLine("Insert a negative or positive number.");
            UserInput = Console.ReadLine();
            Number = Int32.Parse(UserInput);

            if (Number > 0)
            {
                Console.WriteLine("The number is positive");
                    
            }else if (Number < 0)
            {
                Console.WriteLine("The number is negative");
            }else
            {
                Console.WriteLine("The number is 0.");
            }




        }
    }
}
