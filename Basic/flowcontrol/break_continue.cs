using System.Formats.Asn1;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 97; // 1. 97로만 나뉘는 숫자
            // 4 = 2 _ 2
            // 11

            bool isPrime = true;

            for (int i = 0; i < num; i++)
            {
                if((num % i) == 0 )
                {
                    isPrime = false;
                    break;
                }               
            }

            if (isPrime)
                Console.WriteLine("소수입니다.");
            else
                Console.WriteLine("소수가 아닙니다.");
        }
    }
}
