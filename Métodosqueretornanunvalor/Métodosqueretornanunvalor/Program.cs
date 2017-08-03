using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodosqueretornanunvalor
{
    class Program
    {
        static void Main(string[] args)
        {

            // Llamando al método
            Console.WriteLine("La edad es: " + calcularEdad());
            Console.ReadKey(true);
        }
        // Crando un método que retorna un valor
        static int calcularEdad()
        {
            int anioNac, anioAct, edad;
            Console.Write("Ingresa el año actual: ");
            anioAct = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el año de nacimiento: ");
            anioNac = int.Parse(Console.ReadLine());
            // Calculando la edad
            edad = anioAct - anioNac;
            return edad;

        }


    }
}
