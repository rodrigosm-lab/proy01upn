using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proys002c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Solicite al usuario la temperatura(°C) y la humedad(%).
            // 2.Calcule el índice ambiental usando la fórmula:
            // índice = (temperatura × 0.7) +(humedad × 0.3)
            // 3.Muestre el valor del índice y su clasificación usando condicionales:
            //  Menor a 20 Frío
            //  Entre 20 y 30 Confortable
            //  Mayor a 30 Caluroso / Húmedo

            double t, h, i;

            Console.WriteLine("Índice de temperatura y humedad");

            Console.WriteLine("Ingrese temperatura en Celsios °");
            t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese humedad %");
            h = double.Parse(Console.ReadLine());

            i = (t * 0.7) + (h * 0.3);

            Console.WriteLine($"El índice de temperatura y humedad es {i} con clasificación:");

            if (i <= 20)
            {
                Console.WriteLine("Frío");
            }
            else if (i <= 30)
            {
                Console.WriteLine("Confortable");
            }
            else if (i > 30)
            {
                Console.WriteLine("Caluroso / Húmedo");
            }

            Console.ReadKey();
        }
    }
}
