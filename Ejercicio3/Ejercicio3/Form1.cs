namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Image viewer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    openFileDialog.OpenFile();

                }
            }

            try
            {



                Form2 form2 = new Form2();


                Image im = Image.FromFile(filePath);



                form2.Imagen = im;
                form2.FilePath = filePath;





                if (!cb1.Checked)
                {


                    form2.Show();
                }
                else
                {

                    DialogResult res;
                    res = form2.ShowDialog();
                }


            }
            catch (OutOfMemoryException)
            {

            }
            catch (ArgumentException)
            {

            }


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

        private void cb1_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                cb1.ForeColor = Color.Red;
            }
            else
            {
                cb1.ForeColor = Color.Black;
            }
        }
    }
}