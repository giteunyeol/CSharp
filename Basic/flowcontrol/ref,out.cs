using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace csharp
{
    class Program
    {
        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }

        static void Main(string[] args)
        {            
            int num1 = 10;
            int num2 = 3;

            //10 / 3 = 3 * 3 + 1
            int result1;
            int result2;
            Divide(10, 3, out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        } 
    }
}
