using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();


            for (int i = firstName.Length - 1; i == 0; i++)
            {
                Console.Write(firstName[i]);
            }
        }
    }
}
