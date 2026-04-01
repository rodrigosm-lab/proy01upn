using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proys002d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              1.Solicite al usuario:
              o Temperatura ambiental(°C)
              o Horas de exposición al sol
              2.Calcule el índice usando la fórmula:
              índice = (temperatura × 0.6) +(horas × 0.4)
              3.Muestre el resultado y su clasificación usando condicionales:
               Menor a 15 Bajo
               Entre 15 y 25 Moderado
               Mayor a 25 Alto
            */

            double t, h, id;

            Console.WriteLine("Índice de deshidratación");

            Console.WriteLine("Ingrese temperatura ambiental °");
            t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese horas de exposición al sol");
            
            h = double.Parse(Console.ReadLine());

            id = (t * 0.6) + (h * 0.4);

            Console.WriteLine($"El índice de deshidratación es {id} con clasificación:");

            if (id <= 15)
            {
                Console.WriteLine("Bajo");
            }
            else if (id <= 25)
            {
                Console.WriteLine("Moderado");
            }
            else if (id > 25)
            {
                Console.WriteLine("Alto");
            }

            Console.ReadKey();
        }
    }
}
