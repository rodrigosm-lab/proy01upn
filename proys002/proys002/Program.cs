using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proys002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
               // 1.Solicite al usuario una cantidad en metros.
               // 2.Calcule su equivalente en centímetros usando la fórmula:
               // Centímetros = metros × 100
               // 3.Muestre el resultado en pantalla.
           
            double m, cm;
           
            Console.WriteLine("Ingrese cantidad en metros");
            m = double.Parse(Console.ReadLine());    //¿Que significa parse?
            
            cm = m * 100;

            Console.WriteLine($"En {m} m hay {cm} cm");  //¿Que significa interpolar?
            //Para agregarlas variables dentro del texto que el programa nos quiere mostrar
            //debemos agregar $ antes de las comillas y las variables dentro de las comillas
            //deben estar encerradas por {}

            Console.ReadKey();
        }
    }
}
