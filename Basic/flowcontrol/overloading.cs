using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace csharp
{
    class Program
    {
        //함수 이름의 재사용
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            System.Console.WriteLine("Add int 호출");
            return a + b + c;
        }

        static float Add(float a, float b)
        {
            System.Console.WriteLine("Add float 호출");
            return a + b;
        }

        static int Test(int a, int b, int c = 0, float d = 1.0f, double e = 3.0) //c는 옵션, 기본값 0
        {
            Console.WriteLine("Test int 호출");
            return a + b + c;
        }

        static void Main(string[] args)
        {            
            int ret = Program.Add(2, 3, 4);
            float ret2 = Program.Add(2.0f, 3.0f);
            Program.Test(1, 2);
            Program.Test(1, 2, d:2.0f); //c#의 특수 문법

            Console.WriteLine(ret);
        } 
    }
}
