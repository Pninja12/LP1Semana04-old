using System;

namespace Power2Method
{
    class Program
    {
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n) ; i <<= 1)
            {
                Console.WriteLine( i );
            }
        }
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (1 << 5) ; i <<= 1)
            {
                PowersOf2UntilN(i);
            }
        }

        static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
        }
    }
}
