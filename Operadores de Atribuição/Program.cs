using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int a1 = 10;
                Console.WriteLine(a1);

                a1 += 2;
                Console.WriteLine(a1);

                a1 *= 3;
                Console.WriteLine(a1);

                string s = " SÃO BERNARDO ";
                Console.WriteLine(s);

                s += "DO CAMPO";
                Console.WriteLine(s);

                int a = 10;
                a++;
                Console.WriteLine(a);
                
                int b = 10;
                b--;
                Console.WriteLine(b);

            }
        }
    }
}