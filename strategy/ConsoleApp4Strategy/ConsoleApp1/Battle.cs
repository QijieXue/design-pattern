using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Battle
    {
        public Hero[] Heros = new Hero[2];
        public Battle(Hero hero1, Hero hero2)
        {
            Heros[0] = hero1;
            Heros[1] = hero2;
        }

        public void Start()
        {
            int turn = 0;
            while(!isGameOver())
            {
                turn = turn == 1 ? 0 : 1;
                processHeroTurn(turn);
            }

            Console.WriteLine($"胜利者为{Heros[turn].GetName()}");
        }

        private void processHeroTurn(int heroIndex)
        {
            var attackingHero = Heros[heroIndex];
            var attackedHero = Heros[heroIndex == 1 ? 0 : 1];
            Console.WriteLine($"轮到 {Heros[heroIndex].GetName()}");
            attackingHero.attack(attackedHero);

        }

        public bool isGameOver()
        {
            return !(Heros[0].isAlive() && Heros[1].isAlive());
        }
    }
}
