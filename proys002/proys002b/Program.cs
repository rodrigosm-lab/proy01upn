using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proys002b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Solicite al usuario: horas, minutos y segundos.
            // 2.Calcule el tiempo total en segundos usando la fórmula:
            // TotalSegundos = (horas × 3600) +(minutos × 60) +segundos
            // 3.Muestre el resultado en pantalla


            int h, m, s, st;

            Console.WriteLine("Ingresar horas");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar minutos");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar segundos");
            s = int.Parse(Console.ReadLine());

            st = (h * 3600) + (m * 60) + s;

            Console.WriteLine($"El total de segundos son: {st}");
            
            Console.ReadKey();
        }
    }
}
