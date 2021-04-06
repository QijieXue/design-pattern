using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Skill
    {
        int attack(Hero attackingHero, Hero attackedHero);
    }

    class Colliding : Skill
    {
        public int attack(Hero attackingHero, Hero attackedHero)
        {
            int injury = attackingHero.GetStrength() - attackedHero.GetDefense();
            if (injury < 0)
                injury = 0;
            attackedHero.LostHp(injury);
            return injury;
        }

        public override string ToString()
        {
            return "冲撞攻击";
        }
    }

    class Waterball : Skill
    {
        public int attack(Hero attackingHero, Hero attackedHero)
        {
            if (attackingHero.GetMp() == 0)
                return 0;
            attackingHero.LostMp(5);
            int injury = attackingHero.GetWisdom() * 2;
            attackedHero.LostHp(injury);
            return injury;
        }

        public override string ToString()
        {
            return "水球攻击";
        }
    }
}
