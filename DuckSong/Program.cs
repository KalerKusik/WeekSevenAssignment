using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 5; i > 1; i--)
                {
                    Console.WriteLine($"{i} little ducks went swimming one day over the hill and far away");
                    Console.WriteLine($"Mother duck said, Quack quack quack quack but only {i - 1} little duck(s) came back");
                    if (i > 1)
                    {

                    }
                }
                Console.WriteLine("1 little duck went swimming one day over the hill and far away");
                Console.WriteLine($"Mother duck said, Quack quack quack quack but no little ducks came back!");
                Console.WriteLine("Sad mother duck went out one day over the hill and far away");
                Console.WriteLine("The sad mother duck said, Quack quack quack quack and all of the 5 ducks came back!");
            }
        }
    }
}
