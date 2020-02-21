using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            long suma = 0;
            int n = 0;
            int a = 2;

            while (n < 500)
            {
                if (CzyPierwsza(a))
                {
                    suma += a;
                    n++;
                }
                a++;
            }
            Console.WriteLine("suma pierwszych 500 liczb pierwszych: " + suma);

            Console.ReadKey();
        }
        private static bool CzyPierwsza(int a)
        {

            if (a == 1) return false;
            if (a == 2) return true;
            if (a % 2 == 0) return false;

            int x = (int)Math.Floor(Math.Sqrt(a));
            for (int i = 2; i <= x; i++)
            {
                if (a % i == 0) return false;
            }

            return true;

        }
    }
}



