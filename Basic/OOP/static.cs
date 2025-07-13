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
        //필드
        static public int counter = 1; // 오로지 1개만 존재.
        public int id;
        public int hp;
        public int attack;

        static public Test() //유일성 보장
        {
            counter++; 
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight()
        {
           id = counter;
           counter++;

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
            Knight knight = Knight.CreateKnight(); //static
            knight.Move(); // 일반

            System.Console.WriteLine();

            Random rand = new Random();
            rand.Next(0,2);
        }
    }
}
