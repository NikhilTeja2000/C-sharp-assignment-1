using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexe
{
    public class Classque7
    {
        static void Main7()
        {

            Console.WriteLine("Enter number value of a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The addition of a+b is: " + (a + b));
            Console.WriteLine("The subtraction of a-b is: " + (a - b));
            Console.WriteLine("The multiplication of a*b is: " + (a * b));
            Console.WriteLine("The division of a/b is: " + (a / b));
            Console.WriteLine("The mod of a%b is: " + (a % b));
            Console.ReadKey();
        }
    }
}
