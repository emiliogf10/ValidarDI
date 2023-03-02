namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new Ejercicio2.UserControl1();
            this.userControl12 = new Ejercicio2.UserControl1();
            this.userControl13 = new Ejercicio2.UserControl1();
            this.userControl14 = new Ejercicio2.UserControl1();
            this.userControl15 = new Ejercicio2.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl11.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userControl11.Gradiente = true;
            this.userControl11.ImagenMarca = null;
            this.userControl11.Location = new System.Drawing.Point(142, 39);
            this.userControl11.Marca = Ejercicio2.eMarca.Nada;
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(74, 13);
            this.userControl11.TabIndex = 0;
            this.userControl11.Text = "userControl11";
            // 
            // userControl12
            // 
            this.userControl12.Color1 = System.Drawing.Color.Empty;
            this.userControl12.Color2 = System.Drawing.Color.Empty;
            this.userControl12.Gradiente = false;
            this.userControl12.ImagenMarca = null;
            this.userControl12.Location = new System.Drawing.Point(142, 85);
            this.userControl12.Marca = Ejercicio2.eMarca.Cruz;
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(93, 15);
            this.userControl12.TabIndex = 1;
            this.userControl12.Text = "userControl12";
            // 
            // userControl13
            // 
            this.userControl13.Color1 = System.Drawing.Color.Empty;
            this.userControl13.Color2 = System.Drawing.Color.Empty;
            this.userControl13.Gradiente = false;
            this.userControl13.ImagenMarca = null;
            this.userControl13.Location = new System.Drawing.Point(142, 137);
            this.userControl13.Marca = Ejercicio2.eMarca.Circulo;
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(127, 53);
            this.userControl13.TabIndex = 2;
            this.userControl13.Text = "userControl13";
            // 
            // userControl14
            // 
            this.userControl14.Color1 = System.Drawing.Color.Empty;
            this.userControl14.Color2 = System.Drawing.Color.Empty;
            this.userControl14.Gradiente = false;
            this.userControl14.ImagenMarca = null;
            this.userControl14.Location = new System.Drawing.Point(421, -272);
            this.userControl14.Marca = Ejercicio2.eMarca.Nada;
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(74, 13);
            this.userControl14.TabIndex = 3;
            this.userControl14.Text = "userControl14";
            // 
            // userControl15
            // 
            this.userControl15.Color1 = System.Drawing.Color.Empty;
            this.userControl15.Color2 = System.Drawing.Color.Empty;
            this.userControl15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl15.Gradiente = false;
            this.userControl15.ImagenMarca = global::Prueba.Properties.Resources.bombilla;
            this.userControl15.Location = new System.Drawing.Point(344, 73);
            this.userControl15.Marca = Ejercicio2.eMarca.Imagen;
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(238, 43);
            this.userControl15.TabIndex = 4;
            this.userControl15.Text = "userControl15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl15);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio2.UserControl1 userControl11;
        private Ejercicio2.UserControl1 userControl12;
        private Ejercicio2.UserControl1 userControl13;
        private Ejercicio2.UserControl1 userControl14;
        private Ejercicio2.UserControl1 userControl15;
    }
}

