using System;

namespace csharp
{
    //객체 (Object Oriented Programing)
    
    //knight    
    //속성: hp, attack, pos
    //기능: Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;

        public void Move()
        {
            System.Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            System.Console.WriteLine("Knight Attack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}