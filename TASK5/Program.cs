using System;

namespace TASK5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Personality Test
             * People who love cats are homebird
             * People who love dogs are partygoers
             * People who love other animals are just animal friends
             */

            string UserInput;
            Console.WriteLine("What is your favorite animal?");
            UserInput = Console.ReadLine();

            if(UserInput == "cat")
            {
                Console.WriteLine("you are homebird");

            }
            else if (UserInput == "dog")
            {
                Console.WriteLine("you are partygoer");

            }
            else
            {
                Console.WriteLine($"You are a {UserInput} friend");
            }
        }
    }
}
