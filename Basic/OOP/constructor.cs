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

        public Knight()
        {
           hp = 100;
           attack = 10;
           System.Console.WriteLine("생성자 호출!"); 
        }

        // this(): 내 자신의 빈 생성자를 호출시켜줘
        public Knight(int hp) : this()
        {
            this.hp = hp;
            System.Console.WriteLine("int 생성자 호출!");
        }
        public Knight(int hp, int attack) : this()
        {
            this.hp = hp;
            this.attack = attack;
            System.Console.WriteLine("int, int 생성자 호출!");
        }

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
        static void Main(string[] args)
        {
            Knight knight = new Knight(50);
        }
    }
}
