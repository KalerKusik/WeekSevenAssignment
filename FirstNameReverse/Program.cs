using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string userName = Console.ReadLine();

            if(userName.Length >= 5)
            {
                for (int i = userName.Length - 1; i >= 0; i--)
                {
                    Console.Write(userName[i]);
                }
            } 
            else
            {
                Console.WriteLine($"{userName}");
            }

        }
    }
}
