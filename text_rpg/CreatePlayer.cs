using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace csharp
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            knight = 1,
            Archer = 2,
            Mage = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
        }
        static ClassType ChooseClass()
        {
            System.Console.WriteLine("직업을 선택하세요!");
            System.Console.WriteLine("1. 기사");
            System.Console.WriteLine("2. 궁수");
            System.Console.WriteLine("3. 법사");

            string input = Console.ReadLine() ?? "";

            ClassType choice = ClassType.None;
            switch (input)
            {
                case "1":
                    choice = ClassType.knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch (choice)
            {
                case ClassType.knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                player.hp = 0;
                player.attack = 0;
                break;
            }
        }
        static void Main(string[] args)
        {

            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    Player player;

                    int hp;
                    int attack;
                    CreatePlayer(choice, out player);
                    System.Console.WriteLine($"HP : {player.hp} Attack : {player.attack}");

                    // 필드로 가서 몬스터랑 싸운다.
                    break;
                }
            }
        }
    }
}