namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //캐스팅


            //[  ]
            int a = 100;
            //[ ]
            short b = (short)a;

            // 100 -> 100.0f
            float c = a;
            // 50.5f -> 50
            int d = (int)c;
        }
    }
}