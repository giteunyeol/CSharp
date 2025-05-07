using System;

namespace csharp
{
    // OOP(은닉성/상속성/다형성)
    class Player // 부모 클래스 or 기반 클래스
                 // 부모 -> 자식순서로 실행
    {
        //필드
        static public int counter = 1; // 오로지 1개만 존재!
        public int id;
        public int hp;
        public int attack;

        public void Move()
        {
            System.Console.WriteLine("Player Move");
        }

        public void Attack()
        {
            System.Console.WriteLine("Player Attack");
        }

    }

    class Mage : Player

    class Archer : Player

    class Knight : Player // 자식 or 파생 클래스
    {
        public void Stun()
        {
            
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
            Knight knight = new Knight();
            knight.Move();
        }
    }
}