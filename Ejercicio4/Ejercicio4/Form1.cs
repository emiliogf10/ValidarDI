using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {

        public delegate void Op(double x, double y);

        Dictionary<String,Op> operations = new Dictionary<String,Op>();

        public int seconds = 0;
        public int minutes = 0;
        public Form1()
        {
            InitializeComponent();






            operations.Add("+", (valor1, valor2)=>resultado.Text ="Resultado = "+ (valor1 + valor2)+"");
            operations.Add("-", (valor1, valor2) => resultado.Text = "Resultado = " + (valor1 - valor2) + "");
            operations.Add("*", (valor1, valor2) => resultado.Text = "Resultado = " + (valor1 * valor2) + "");
            operations.Add("/", (valor1, valor2) => resultado.Text = "Resultado = " + (valor1 / valor2) + "");
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        private void sumar_CheckedChanged(object sender, EventArgs e)
        {


            label.Text = ((RadioButton)sender).Text;


        }

        private void TextChanged(object sender, EventArgs e)
        {

            double temmp = 0;
            string text = ((TextBox)sender).Text.Trim();

            if (double.TryParse(text, out temmp) || text.Equals(""))
            {
                ((TextBox)sender).BackColor = Color.White;

            }
            else
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            try
            {
                bool valor1 = double.TryParse(textBox1.Text, out double v1);
                bool valor2 = double.TryParse(textBox2.Text, out double v2);
                v1 = double.Parse(textBox1.Text);
                v2 = double.Parse(textBox2.Text);


                operations[label.Text](v1, v2);

               if(v1==0 && v2==0 && label.Text.Equals("/"))
                {
                    resultado.Text = "Resultado = ";
                    MessageBox.Show("Can't do this operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            catch (FormatException)
            {
                


                
                    MessageBox.Show("There must be 2 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (KeyNotFoundException)
            {
                    MessageBox.Show("There must be a selected operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            Text = String.Format("{0,2}:{1,2}", minutes.ToString("D2"), seconds.ToString("D2"));
            seconds++;
        }


    }

       
    
}