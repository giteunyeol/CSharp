namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0:가위  1:바위  2:보

            Random rand = new Random();
            int aiChoice = rand.Next(0,3); // 0 ~ 2 사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("가위 선택");
                    break;
                case 1:
                    Console.WriteLine("바위 선택");
                    break;
                case 2:
                    Console.WriteLine("보 선택");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터 가위 선택");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터 바위 선택");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터 보 선택");
                    break;
            }

            // 승리 무승부 패배
            if (choice == aiChoice)
            {
                Console.WriteLine("무승부입니다");
            }
            else if (choice == 0 && aiChoice == 2)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == 1 && aiChoice == 0)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == 2 && aiChoice == 1)
            {
                Console.WriteLine("승리입니다.");
            }
            else
            {
                Console.WriteLine("패배입니다.");
            }

        }
    }
}