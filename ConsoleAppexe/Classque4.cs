using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe
{
    public class Classque4
    {
        static void Main4()
        {
            int a = -1;
            int b = 4;
            int c = 6;

            Console.WriteLine("The Result of Following expression -1 + 4 * 6  is:" + (a+b*c));

            int aa = 35;
            int ba = 5;
            int ca = 7;

            Console.WriteLine("The Result of Following expression ( 35+ 5 ) % 7  is:" + (aa + ba) % ca);

            int aaa = 14;
            int baa = -4;
            int caa = 11;

            Console.WriteLine("The Result of Following expression 14 + -4 * 6 / 11 is:" + (aaa + baa * c / caa));

            int aaaa = 2;
            int baaa = 1;
            int caaa = 15;

            Console.WriteLine("The Result of Following expression 14 + 2 + 15 / 6 * 1 - 7 % 2 is:" + (aaaa + caaa / c * baaa - ca % aaaa));
            Console.ReadKey();
        }

    }
}
