using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proys002fa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre");
            Console.WriteLine("Ingrese datos médicos");
            Console.WriteLine("Frecuencia cardiaca (latidos por minuto):");
            fc = int.Parse(Console.ReadLine());
            Console.WriteLine("Presión arterial sistólica (PAS) en mmHg:");
            pas = int.Parse(Console.ReadLine());
            Console.WriteLine("Presión arterial diastólica (PAD) en mmHg:");
            pad = int.Parse(Console.ReadLine());
            Console.WriteLine("Temperatura corporal en °C:");
            temperatura = double.Parse(Console.ReadLine());

            double pam = pad + (pas - pad) / 3.0;
            double ic = (double)fc / pas;
            Console.WriteLine($"Frecuencia cardiaca: {fc}");
            Console.WriteLine($"PAS: {pas}");
            Console.WriteLine($"PAD: {pad}");
            Console.WriteLine($"Temperatura: {temperatura:F1} °C");
            Console.WriteLine($"IC: {ic:F2}");

            string leyenda = "";

            if (ic >= 0.5 && ic <= 0.7)
            {
                leyenda = "Normal";
            }
            else if (ic > 0.7 && ic <= 0.9)
            {
                leyenda = "ligeramente elevado (vigilar)";
            }
            else if (ic > 0.9 && ic <= 1)
            {
                leyenda = "Posible estado de choque (riesgo)";
            }
            else if (ic >= 1)
            {
                leyenda = "alto riesgo (grave)";
            }
            Console.WriteLine($"Calsificación IC: {leyenda}");
        }
    }
}
