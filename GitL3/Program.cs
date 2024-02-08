using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitL3
{
    internal class Program
    {

        static void Main()
        {
            double x = 1.5;  // Значение x, для которого нужно вычислить функцию
            double result = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
            Console.WriteLine("Результат функции 8sin(2x) - cos(2x) при x = " + x + " равен " + result);


        }
    }
}
