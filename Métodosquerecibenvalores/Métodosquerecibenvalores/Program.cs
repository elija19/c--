using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodosquerecibenvalores
{
    class Program
    {
        static void Main(string[] args)
        {
            solicitarDatos(); // Calcular la edad 
            Console.ReadKey(true);
        }

        // Creando un método que recibe valores
        static void calcularEdad(int anioAct, int anioNac)
        {
            int edad;
            edad = anioAct - anioNac;
            Console.WriteLine(" La edad es: " + edad);
        }
        static void solicitarDatos()
        {
            int aa, an;
            Console.WriteLine(" Ingresa el año actual: " );
            aa = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresa el año de nacimiento: ");
            an = int.Parse(Console.ReadLine());
            calcularEdad(aa, an); // se le aginan y el método realiza la operación
        }

    }
}
