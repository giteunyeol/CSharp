using System.Formats.Asn1;

namespace csharp
{
    class Program
    {
        //method function 
        /*
        한정자 반환형식 이름(매개변수목록)
        {

        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        */
        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            // 4, 5 => 9
            int result = Program.Add(4,5);
            Console.WriteLine(result);
        }
        //****** c#에서는 앞에 ref로 붙이는 방식으로 래퍼런스로 넘김
    }
}
