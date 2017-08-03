using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pila
{
    public partial class Form1 : Form
    {
        pila objeto = new pila(); // Invocación de la clase pila para utilizarla con el form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtmaximo.Text); // Dato de la caja de texto máximo sea enviado a la clase pila(objeto)
            objeto = new pila(m);
            MessageBox.Show("Pila creada"); 
        }

        private void btnpush_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtnumero.Text); // Agrega el valor de la caja de texto numero
            objeto.push(n);
            txtnumero.Clear();// Limpiar para poner nueva cantidad
            txtnumero.Focus();
        }

        private void btnpop_Click(object sender, EventArgs e)
        {
            int n;
            n = objeto.pop();
            MessageBox.Show("Salio" + n);
        }
    }
}
