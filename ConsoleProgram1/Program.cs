using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<double> lstNumero = new List<double>();
            bool seguir = true;
            while (seguir)
            {
                Console.WriteLine("Bienvenido al mejor programa de la historia!!!!");

                Console.WriteLine("Introducir un numero: ");
                string teclado = Console.ReadLine();
                double num;
                double.TryParse(teclado, out num);
                if (num > 0)
                {
                    lstNumero.Add(num);   
                }
                Console.WriteLine("Ultimo numero de la lista? S) si, N) No");
                string sig = Console.ReadLine();
                if (sig == "Si")
                {
                    seguir = false;
                    double sum = 0;
                    try
                    {
                        foreach (double n in lstNumero)
                        {
                            sum += n;
                        }
                        double prom = sum / lstNumero.Count;
                        Console.WriteLine("El Promedio es: " + prom.ToString());
                        double sumatoria = 0;
                        foreach (int x in lstNumero)
                        {
                            sumatoria += Math.Pow((x - prom), 2);
                        }
                        Console.WriteLine("Desviacion estandar es: " + Math.Sqrt((sumatoria / (lstNumero.Count - 1))));

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();
                }
            }
        }

    }
}
