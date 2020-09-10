using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("What is your number");
            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);
            Console.WriteLine("What is your second number");
            UserInput = Console.ReadLine();
            int Num2 = Int32.Parse(UserInput);

            if(Num1 == Num2)
            {
                Console.WriteLine("the numbers you provided are equal");
                
            }else
            {
                Console.WriteLine("the numbers you provided are NOT equal");
            }



            




            
        }
        
       


    }
}
