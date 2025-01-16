using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        switch (choice)
        {
            case 0:
                Console.WriteLine("가위");
                break;
            case 1:
                Console.WriteLine("바위");
                break;
            case 2:
                Console.WriteLine("보");
                break;
            case 3:
                Console.WriteLine("치트");
                break;
            default:
                Console.WriteLine("실패");
                break;
        }
        //삼항 연산자
        int number = 25;

        // bool isPair = (조건 ? 맞을때 : 틀릴때);

        bool isPair = ((number % 2) == 0 ? true : false);
    }
}
