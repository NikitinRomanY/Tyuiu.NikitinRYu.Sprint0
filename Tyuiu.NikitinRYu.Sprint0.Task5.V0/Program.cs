using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NikitinRYu.Sprint0.Task5.V0.Lib;

namespace Tyuiu.NikitinRYu.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("А + В = " + DataService.Addition(1, 5));
            Console.WriteLine("А - В = " + DataService.Subtraction(15, 5));
            Console.WriteLine("А * В = " + DataService.Multiplication(10, 10));
            Console.WriteLine("А / В = " + DataService.Division(9, 3));

            Console.ReadKey();
        }
    }
}
