using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LibroCalificaciones
{
    //Muestra un mensaje de bienvenida 
    public void MostrarMensaje(string nombreCurso)
    {
        Console.WriteLine( "Bienvenido al libro de calificaciones para \n "+ nombreCurso + "!");
         
        Console.ReadKey();
    }
}