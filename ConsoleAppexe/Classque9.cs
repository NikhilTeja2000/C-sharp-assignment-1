using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe
{
    public class Classque9
    {
        static void Main9()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enterfourth number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average of "+a+"," + b + "," + c + "," + d + " is: " + ((a+b+c+d)/4));
            Console.ReadKey();

        }
    }
}
