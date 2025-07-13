using System;

namespace csharp
{
    // OOP(은닉/상속/다형)
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            System.Console.WriteLine("Player 이동!");
        }
    }
    //오버로딩(함수 이름의 재사용)) 오버라이딩(다형성) 
    class Knight : Player
    {
        public override void Move()
        {
            System.Console.WriteLine("Knight 이동!");
        }
    }

    class Mage : Player
    {
        public int mp;
        public new void Move()
        {
            System.Console.WriteLine("Mage 이동!");
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();
            
            Mage mage = (player as Mage); // is와 as는 거의 같은 기능, as 추천
            if (mage != null)
            {
                mage.mp = 10;
                mage.Move();
            }

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(mage);

        }
    }
}
