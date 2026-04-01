using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proys002e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              1. Solicite al usuario:
              o Temperatura interior (°C)
              o Nivel de ruido (dB)
              2. Calcule el índice usando la fórmula:
              índice = (temperatura × 0.5) + (ruido × 0.5)
              3. Muestre el resultado y su clasificación usando condicionales:
               Menor a 30 → Muy cómodo
               Entre 30 y 50 → Cómodo
               Entre 51 y 70 → Poco cómodo
               Mayor a 70 → Incómodo
            */

            double t, db, ic;

            Console.WriteLine("Índice de comodidad en interiores");

            Console.WriteLine("Ingrese temperatura interior C°");
            t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nivel de ruido (db)");
            db = double.Parse(Console.ReadLine());

            ic = (t * 0.5) + (db * 0.5);

            Console.WriteLine($"El índice de comodidad en interior es {ic} con clasificación:");

            if (ic <= 30)
            {
                Console.WriteLine("Muy cómodo");
            }
            else if (ic <= 50)
            {
                Console.WriteLine("Cómodo");
            }
            else if (ic <= 70)
            {
                Console.WriteLine("Poco cómodo");
            }
            else if (ic > 70)
            {
                Console.WriteLine("Incómodo");
            }

            Console.ReadKey();



        }
    }
}
