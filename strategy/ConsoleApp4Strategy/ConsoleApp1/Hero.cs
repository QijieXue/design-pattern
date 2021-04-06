namespace ConsoleApp1
{
    using System;
    class Hero
    {
        private string name;
        public string GetName()
        {
            return name;
        }
        private int hp = 500;
        public int GetHp()
        {
            return hp;
        }
        public void SetHp(int hp)
        {
            this.hp = hp;
        }
        private int mp = 200;
        public int GetMp()
        {
            return this.mp;
        }
        private int strength = 150;
        public int GetStrength()
        {
            return this.strength;
        }
        
        private int wisdom = 80;
        public int GetWisdom()
        {
            return this.wisdom;
        }
        private int defense = 50;
        public int GetDefense()
        {
            return this.defense;
        }

        private Skill skill;

        public Hero(string name, Skill skill)
        {
            this.name = name;
            this.skill = skill;
        }

        public void attack(Hero targetHero)
        {
            int injury = skill.attack(this, targetHero);
            Console.WriteLine($"{this.name} 攻击了 {targetHero.name}; 伤害值是 {injury}");
            Console.WriteLine($"{this.name} 血值 {this.hp}; {targetHero.name} 血值 {targetHero.hp}");
        }

        public bool isAlive()
        {
            return hp > 0;
        }
        public void LostHp(int hp)
        {
            if (this.hp - hp >= 0)
                this.hp -= hp;
            else
                this.hp = 0;
        }

        public void LostMp(int mp)
        {
            if (this.mp - mp >= 0)
                this.mp -= mp;
            else
                this.mp = 0;
        }
    }


}
