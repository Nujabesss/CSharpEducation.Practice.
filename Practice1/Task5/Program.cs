using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Radius = 13;
            const double Pi = Math.PI;
            double Square = Pi * Math.Pow(Radius, 2);
            Console.WriteLine($"Плошадь круга с радиусом 13 = {Square} ");
            Console.ReadKey();
        }
    }
}
