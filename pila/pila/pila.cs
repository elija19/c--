using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Esta linea ayuda a la comunicación con el form

namespace pila
{
    class pila
    {
        private int maximo; // Valor máximo de espacios que tendrá la pila
        private int cima;   // Valor que está arriba de la cima de la pila "último en entrar, primero en salir."
        private int[] lapila; // Vector o arreglo donde se almacena toda la información de la pila
        public pila() { }  // Constructor con parámetros vacios
        public pila(int max) // Constructor con parámetros llenos
        {
            lapila = new int[max]; 
            maximo = max;
            cima = -1;

        }

        public Boolean pila_llena() // Lógica para revisar si la pila se lleno
        {
            if ( cima == maximo-1) // Pila llena
            { return true; }
            else
            { return false; } // Pila no llena aún
        }

        public Boolean pila_vacia ()
        {
            if (cima == -1) // Pilla vacia
                return true;
            else
                return false; // Pila no vacia
        }

        public void push(int n) // Agregar a la pila
        {
            if(pila_llena()== true) // Condición de pila llena
            {
                MessageBox.Show("Pila llena");
            }
            else
            { cima++; lapila[cima] = n; } // Si no está llena se agregara un valor dentro de la pila
        }
        public int pop()
        {
            int n = 0;
            if(pila_vacia()==true) // Condición para verificar estado de pila
            {
                MessageBox.Show("Pila Vacia");
                return n; // Devuelve para ingresar valor
            }
            else
            {
                n= lapila[cima];
                cima--;   // si no está vacia se quita un valor de la pila
                return n; // Devuelve para ingresar valor o quitar
            }

        }
    }
}
