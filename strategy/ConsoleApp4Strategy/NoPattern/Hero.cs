using System;
using System.Collections.Generic;
using System.Text;

namespace NoPattern
{
    class Hero
    {
        private string name;
        private int hp = 500;
        private int mp = 200;
        private int strength = 150;
        private int wisdom = 80;
        private int defense = 50;

        private Skill skill;
        public enum Skill
        {
            Colliding, Waterball
        }

        public Hero(string name, Skill skill)
        {
            this.name = name;
            this.skill = skill;
        }

        public void attack(Hero targetHero)
        {
            int injury = 0;
            switch(skill)
            {
                case Skill.Colliding:
                    {
                        injury = this.strength - targetHero.defense;
                        targetHero.hp -= injury;

                    };break;
                case Skill.Waterball:
                    {
                        this.mp -= 5;
                        injury = this.wisdom * 2;
                        targetHero.hp -= injury;
                    };break;
            }

            Console.WriteLine($"{this.name}向{targetHero.name}发起了{skill.ToString()} 攻击， 伤害值是{injury}");
            Console.WriteLine($"{this.name}血值{this.hp}; {targetHero.name}血值{targetHero.hp}");
        }

        public bool isAlive()
        {
            return this.hp > 0;
        }

        public string GetName()
        {
            return name;
        }
    }
}
