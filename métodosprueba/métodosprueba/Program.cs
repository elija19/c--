using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace métodosprueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objeto = new Program();
            objeto.solicitarDatos();
            objeto.imprimirEdad();
            Console.ReadKey(true);
        }

        //Creando las variables de la clase para los métodos

        private int añoAct, añoNac, edad;

     void solicitarDatos()
        {
            Console.WriteLine("Ingresa año actual: ");
            añoAct = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa año actual: ");
            añoNac = int.Parse(Console.ReadLine());
        }

    int calcularEdad()
        {

            edad = añoAct - añoNac;
            return edad;
           
        }

        void imprimirEdad()
        {

            
            Console.WriteLine("La edad es: "+ calcularEdad());
        }


    }
}
