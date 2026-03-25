
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radio cm:");
            double r = Double.Parse(Console.ReadLine());
            double ac = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Ac es {ac:F2} cm²");
            Console.ReadKey();
            
        }
    }
}
