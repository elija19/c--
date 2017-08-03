using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodosqueejecutan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invocando al método
            // Creando instancia u objeto de la clase
            Program objeto = new Program();
            objeto.solicitarNombre();
         
            Console.ReadKey(true);
        }

        // Parte para crear los Métodos
        // Creando un método
         void solicitarNombre()
        {
            string nom;
            Console.Write("Ingresa tu nombre:");
            nom = Console.ReadLine();
            Console.Write("Bienvenido " +  nom);

        }

    }
}
