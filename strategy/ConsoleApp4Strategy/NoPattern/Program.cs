using System;

namespace NoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var h1 = new Hero("小明", Hero.Skill.Colliding);
            var h2 = new Hero("小红", Hero.Skill.Waterball);
            Battle battle = new Battle(h1, h2);
            battle.Start();
            Console.ReadLine();
        }
    }
}
