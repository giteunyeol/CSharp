using System;

namespace csharp
{
    // 매소드 호출 = > 인셉션 
    // 현실 -> 1차 꿈 -> 2차 꿈 -> 3차 꿈 
    class Program
    {
        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        static int Add(int a, int b)
        {
            int ret =  a + b;
            Print(ret);
            return ret;
        }
        static void Main(string[] args)
        {   
            int ret = Program.Add(10,20);
            Console.WriteLine(ret);
        } 
    }
}
