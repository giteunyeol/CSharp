using System.Formats.Asn1;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //거울아 거울아
            string answer;
            
            do
            {
                Console.WriteLine("당신은 잘생기셨나요? (y/n)");
                answer = Console.ReadLine();
            } while(answer != "y");
        }
    }
}