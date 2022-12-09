namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ejercicio 2";

        }

        private void botonColor_Click(object sender, EventArgs e)
        {
            try
            {

                //Se comprueba que los numeros no son letras, si no devuelve false y establece out a 0
                int i = 0;
                bool result1 = int.TryParse(color1.Text, out i);
                bool result2 = int.TryParse(color2.Text, out i);
                bool result3 = int.TryParse(color3.Text, out i);

                if(result1 && result2 && result3) //Si son numeros
                {
                    int color_1 = int.Parse(color1.Text);
                    int color_2 = int.Parse(color2.Text);
                    int color_3 = int.Parse(color3.Text);


                    //Comprueba que son numeros comprendidos entre 0 y 255 (ambos incluidos)
                    if (((color_1 >= 0) && (color_1 <= 255)) && ((color_2 >= 0) && (color_2 <= 255)) && ((color_3 >= 0) && (color_3 <= 255)))
                    {
                        this.BackColor = Color.FromArgb(color_1, color_2, color_3);


                    }
                    else
                    {

                        MessageBox.Show("Debe introducir numeros validos(mayores o iguales que 0 y menores o iguales que 255", "Mi aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Los numeros RGB tienen que ser numeros, no letras", "Mi aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

               


            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid Cast Exception");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception");
            }



        }

        private void botonImagen_Click(object sender, EventArgs e)
        {
            //string imagen = textoImagen.Text;
            //Image image = Image.FromFile(imagen);

            try
            {
                pictureBox1.Image = Image.FromFile(textBox1.Text);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Imagen no encontrada","Mi aplicacion",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Debe escribir un path", "Mi aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }



        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

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

        private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Application.Exit();

            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender == botonColor)
            {
                botonColor.BackColor = Color.Red;

            }
            else if (sender == botonSalir)

            {
                botonSalir.BackColor = Color.Red;
            }
            else if (sender == botonImagen)

            {
                botonImagen.BackColor = Color.Red;
            }
        }


        private void salir(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        private void cargar(object sender, EventArgs e)
        {
            if (color1.Focus() == true || color2.Focus() == true || color3.Focus() == true)
            {
                AcceptButton = botonColor;
            }
            else
            {
                AcceptButton = botonImagen;
            }
        }

        private void color1_Enter(object sender, EventArgs e)
        {
            AcceptButton = botonColor;
        }

        //private void color2_enter(object sender, eventargs e)
        //{
        //    acceptbutton = botoncolor;
        //}

        //private void color3_enter(object sender, eventargs e)
        //{
        //    acceptbutton = botoncolor;
        //}

        private void textBox1_Enter(object sender, EventArgs e)
        {
            AcceptButton = botonImagen;
        }
    }

    
}