using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PruebaComponentes
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbltxtbox.Posicion == Ejercicio1.ePosicion.IZQUIERDA)
            {
                lbltxtbox.Posicion = Ejercicio1.ePosicion.DERECHA;
                this.Text = "DERECHA";
            }
            else
            {
                lbltxtbox.Posicion = Ejercicio1.ePosicion.IZQUIERDA;
                this.Text = "IZQUIERDA";
            }
        }

        private void lbltxtbox_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = "Código: " + e.KeyValue.ToString();
        }

        

    }
}
