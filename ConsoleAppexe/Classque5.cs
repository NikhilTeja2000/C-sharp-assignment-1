using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe
{
    public class Classque5
    {
        static void Main5()
        {
            int a = 5;
            int b = 6;
            (a, b) = (b, a);
            Console.WriteLine(a+","+ b);

            Console.WriteLine("another way of swapping  a:"+a+" and b:"+b+" is -");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a+","+b);


            Console.ReadKey();


        }
    }
}
