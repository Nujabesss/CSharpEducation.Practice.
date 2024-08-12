using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Ваше имя");
            name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
            Console.ReadKey();
        }
    }
}
