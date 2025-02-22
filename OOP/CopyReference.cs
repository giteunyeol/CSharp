using System;

namespace csharp
{
    //객체 (Object Oriented Programing)
    
    //knight    
    //속성: hp, attack, pos
    //기능: Move, Attack, Die

    //ref
    class Knight
    {
        public int hp;
        public int attack;

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        public void Move()
        {
            System.Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            System.Console.WriteLine("Knight Attack");
        }
    }

    //복사
    struct Mage
    {
        public int hp;
        public int attack;
    }
    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }
        static void KillKinght(Knight knight)
        {
            knight.hp = 0;
        }
        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            Knight knight2 = knight.Clone();
            knight2.hp = 0;
            
        }
    }
}