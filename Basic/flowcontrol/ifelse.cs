using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0; // 0:가위 1:바위 2:보

            if (choice == 0)
                Console.WriteLine("가위");
            else if (choice == 1)
                Console.WriteLine("바위");
            else if (choice == 2)
                Console.WriteLine("보");
        }
    }
}
