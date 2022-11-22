#define TECLA
using Microsoft.VisualBasic.Devices;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.Text = "Mouse Tester";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mover(object sender, MouseEventArgs e)
        {




            if (sender is Button)
            {
            

                Text = String.Format(" Mouse Tester X:{0}, Y:{1} ", ((Button)sender).Location.X + e.Location.X, ((Button)sender).Location.Y + e.Location.Y);

            
            }
            else
            {
                Text = String.Format("Mouse Tester X:{0}, Y:{1} ", e.Location.X, e.Location.Y);
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

            Text = "Mouse Tester";



        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Green;

            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;

            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if TECLAS


            this.Text = String.Format("Letra pulsada:{0}", e.KeyValue.ToString());

            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }

            //Text = String.Format("La letra es:{0}", e.KeyCode);
#endif
        }


        private void Form1_mantener(object sender, KeyPressEventArgs e)
        {
#if !TECLAS
            this.Text = String.Format("El caracter pulsado es: {0}",e.KeyChar.ToString());

            if (e.KeyChar.Equals("Esc"))
            {
                this.Text = "Mouse Tester";
            }

#endif

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
