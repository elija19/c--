using System;
    public class PruebaLibroCalificaciones
    {
    // Método Main comienza la ejecución del programa
        static void Main(string[] args)
        {
        //Crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();

        //Pide el nombre del curso y lo recibe como entrada
        Console.WriteLine("Por favor escribe el nombre del curso:");
        string pepin = Console.ReadLine();
        Console.WriteLine();

        // Llama al método MostrarMnesaje de miLibroCalificaciones
        //y pasa nombreDelCurso como argumento
        miLibroCalificaciones.MostrarMensaje(pepin);
        
        }
    
    }

