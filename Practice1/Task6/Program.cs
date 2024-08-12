using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static double Katet(double c, double b) //a гипотенуза ,б известный катет
        {
            return Math.Sqrt(c * c - b * b);
        }
        static double Gypo(double a, double b) { return Math.Sqrt(a * a + b * b); }
        static void Main(string[] args)
        {
            double Katet1 = 3;
            double Katet2 = 4;
            double gypotenuza = 5;

            Console.WriteLine($"Гипотенуза = {Gypo(Katet1, Katet2)}");
            Console.WriteLine($"Катет = {Katet(gypotenuza, Katet2)}");
            Console.ReadKey();

        }
    }
}
