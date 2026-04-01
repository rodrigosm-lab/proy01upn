using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace proys002f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Desarrollar un programa que permita simular la adquisición de signos vitales de un paciente, calcular
               indicadores importantes y mostrar resultados con el formato adecuado.
               1. Solicitar al usuario los siguientes datos:
                 o Frecuencia cardíaca (FC) en latidos por minuto (bpm)
                 o Presión arterial sistólica (PAS) en mmHg
                 o Presión arterial diastólica (PAD) en mmHg
                 o Temperatura corporal en °C
               2. Calcular los siguientes indicadores:
                 o Presión arterial media (PAM):
                   PAM = PAD + (PAS - PAD)/3
                 o Índice de choque (IC):
                   IC = FC / PAS
               3. Mostrar los resultados de manera formateada:
                 o FC, PAS y PAD: enteros
                 o Temperatura: 1 decimal
                 o PAM: 1 decimal
                 o IC: 2 decimales
                     0.5 – 0.7 Normal
                     0.7 – 0.9 Ligeramente elevado (vigilar)
                     > 0.9 Posible estado de choque (riesgo)
                     ≥ 1.0 Alto riesgo, posible shock grave
               4. Aplicar estructuras repetitivas para que solicite de varios pacientes

            */

            Console.WriteLine("//Simulación de signos vitales//");
            List<string> pacientes = new List<string>();

            int opcion, fc, pas, pad;
            double temperatura;
            do
            {
                Console.WriteLine("Bienvenido usuario");
                Console.WriteLine("Selecione opción para continuar");
                Console.WriteLine("1.- Ingresar  Nuevo Usuario y registrar datos vitales con resultados");
                Console.WriteLine("2.- Lista de pacientes con resultados");
                Console.WriteLine("3.- Cerrar programa");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese DNI");
                        string dni = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese datos médicos");
                        Console.WriteLine("");
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
                        string paciente = $"Nombre: {nombre} | DNI: {dni} | FC: {fc} | PAS: {pas} | PAD: {pad} | Temp: {temperatura:F1} | PAM: {pam:F1} | IC: {ic:F2} | Leyenda: {leyenda}";
                        pacientes.Add(paciente);
                        break;
                        
                    case 2:
                        if (pacientes.Count == 0)
                        {
                            Console.WriteLine("No hay pacientes registrados");
                        }
                        foreach (string s in pacientes)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 3:

                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            } while (opcion != 3) ;
                Console.WriteLine("Gracias por usar este programa");
        }
    }
}

// Que es CHAR.TOUPPER(CONSOLO.READKEY().KEYCHAR);