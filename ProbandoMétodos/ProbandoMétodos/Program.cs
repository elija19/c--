using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoMétodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocando el método
            //Se crea la instancia de la clase
            Program edad = new Program();
           
            edad.imprimirEdad();

            Console.ReadKey(true);
        }

        //Variables de la clase
        public int anioNac, anioAct, edad;
        // Método
         int calcularEdad()
        {
            Console.Write("Ingresa año actual: ");
            anioAct = int.Parse(Console.ReadLine());
            Console.Write("Ingresa año de nacimiento: ");
            anioNac = int.Parse(Console.ReadLine());
            edad = anioAct - anioNac;
            return edad;

        }
         void imprimirEdad()
        {
            Console.WriteLine("La edad tuya es: " + calcularEdad());
            
        }
    }
}
