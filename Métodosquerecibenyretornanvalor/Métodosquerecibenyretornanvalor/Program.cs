using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodosquerecibenyretornanvalor
{
    class Program
    {
        static void Main(string[] args)
        {
            solicitarDatos();
            Console.ReadKey(true);
        }
        //Creando un método que recibe valores y retorna
        static int calcularEdad(int anioAct, int anioNac)
        {
            int edad;
            edad = anioAct - anioNac;
            return edad;
        }
        static void solicitarDatos()
        {
            int aa, an;
            Console.WriteLine(" Ingresa el año actual: ");
            aa = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresa el año de nacimiento: ");
            an = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu edad es: " +calcularEdad(aa, an)); // El valor retornado es llamado aquí
        }
    }
}
