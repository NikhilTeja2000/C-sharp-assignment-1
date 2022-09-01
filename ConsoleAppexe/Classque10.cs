using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe
{
    static class Classque10
    {
        static void Main10()
        {
            Console.WriteLine("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of specified numbers "+x+","+y+" and "+a+", (x+y).a is "+ ((x + y)*a) + " and x.y + y.a is "+ ((x*y) + (y*a)));
            Console.ReadKey();

        }
    }
}
