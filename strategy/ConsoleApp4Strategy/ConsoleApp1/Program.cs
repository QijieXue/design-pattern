using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hero h1 = new Hero("小明", new Colliding());
            Hero h2 = new Hero("小红", new Waterball());
            Battle battle = new Battle(h1, h2);
            battle.Start();
            Console.ReadLine();
        }
    }
}
