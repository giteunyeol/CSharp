using System;

namespace csharp
{
    // OOP(은닉성/상속성/다형성)

    // 자동차
    // 핸들 페달 문열기 
       // 전기장치 엔진 기름 <-> 외부 노출  

    class Knight
    {
        //접근 한정자
        //public protected(외부노출 x, 자식에게만 열어줄때) private 
        protected int hp;
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.SetHp(100);
        }
    }
}
