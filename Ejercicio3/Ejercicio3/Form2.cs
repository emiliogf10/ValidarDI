using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            
        }

        Image imagen;
        string filePath;

        public string FilePath
        {
            set { filePath = value; }
        }

        public Image Imagen
        {
            set {imagen = value;}
        }

        private void Form2_Load(object sender,EventArgs e)
        {
            pb.Image = imagen;
            
            FileInfo f = new FileInfo(filePath);
            Text = f.Name;


        }

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            
            
        }



    }
}
