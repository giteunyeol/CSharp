using System;

namespace csharp
{
    // OOP(은닉/상속/다형)
    class Player
    {
        protected int hp;
        protected int attack;
    }
    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            Mage mage = (player as Mage); // is와 as는 거의 같은 기능, as 추천
            if (mage != null)
            {
                mage.mp = 10;
            }
        }

        static void Main(string[] args)
        {
            Knight knight2 = null;
            Knight knight = new Knight();
            Mage mage = new Mage();

            //부모타입 -> 자식타입으로 넘어가는건 될 수도 안 될 수도 있음.
            //Mage 타입 -> Player 타입
            //Player 타입 -> Mage 타입 ??

            EnterGame(mage);

        }
    }
}