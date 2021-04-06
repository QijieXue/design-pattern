using System;
using System.Collections.Generic;
using System.Text;

namespace NoPattern
{
    class Battle
    {
        private Hero[] heroes = new Hero[2];

        public Battle(Hero h1, Hero h2)
        {
            heroes[0] = h1;
            heroes[1] = h2;
        }

        public void Start()
        {
            int turn = 1;
            while(!isGameOver())
            {
                turn = turn == 0 ? 1 : 0;
                processHeroTurn(turn);
            }

            Console.WriteLine($"胜利者为{heroes[turn].GetName()}");
        }

        private void processHeroTurn(int turn)
        {
            Console.WriteLine($"轮到{heroes[turn].GetName()}");
            heroes[turn].attack(heroes[turn == 0 ? 1 : 0]);
        }

        public bool isGameOver()
        {
            return !heroes[0].isAlive() || !heroes[1].isAlive();
        }
    }
}
