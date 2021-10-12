
using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Username:");
                string username = Console.ReadLine();

                Console.WriteLine("Password:");
                string password = Console.ReadLine();

                Console.WriteLine("PIN:");
                string pin = Console.ReadLine();

                if(username == "joe" && password == "joemama69" && pin == "6969")
                {
                    break;
                }
                else if(username == "joe" && password == "joemama69" && pin != "6969")
                {
                    Console.WriteLine("Wrong PIN stupid, try again");
                    i = i + 1;
                }
                else
                {
                    Console.WriteLine("You stupid, try again");
                    i = i + 1;
                }
            }
            if(i < 3)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("YOU ARE SO STUPID!!!");
            }
        }













    }
}
