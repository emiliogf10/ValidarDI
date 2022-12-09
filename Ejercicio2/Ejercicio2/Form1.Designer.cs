namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botonSalir = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.TextBox();
            this.color3 = new System.Windows.Forms.TextBox();
            this.color2 = new System.Windows.Forms.TextBox();
            this.botonColor = new System.Windows.Forms.Button();
            this.botonImagen = new System.Windows.Forms.Button();
            this.etiquetaImagen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(228, 392);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(332, 23);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            this.botonSalir.MouseLeave += new System.EventHandler(this.salir);
            this.botonSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(34, 91);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(134, 23);
            this.color1.TabIndex = 0;
            this.color1.Click += new System.EventHandler(this.cargar);
            this.color1.Enter += new System.EventHandler(this.color1_Enter);
            // 
            // color3
            // 
            this.color3.Location = new System.Drawing.Point(374, 91);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(155, 23);
            this.color3.TabIndex = 2;
            this.color3.Click += new System.EventHandler(this.cargar);
            this.color3.Enter += new System.EventHandler(this.color1_Enter);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(206, 91);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(143, 23);
            this.color2.TabIndex = 1;
            this.color2.Click += new System.EventHandler(this.cargar);
            this.color2.Enter += new System.EventHandler(this.color1_Enter);
            // 
            // botonColor
            // 
            this.botonColor.Location = new System.Drawing.Point(592, 89);
            this.botonColor.Name = "botonColor";
            this.botonColor.Size = new System.Drawing.Size(114, 23);
            this.botonColor.TabIndex = 3;
            this.botonColor.Text = "Color";
            this.botonColor.UseVisualStyleBackColor = true;
            this.botonColor.Click += new System.EventHandler(this.botonColor_Click);
            this.botonColor.MouseLeave += new System.EventHandler(this.salir);
            this.botonColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // botonImagen
            // 
            this.botonImagen.Location = new System.Drawing.Point(207, 201);
            this.botonImagen.Name = "botonImagen";
            this.botonImagen.Size = new System.Drawing.Size(142, 23);
            this.botonImagen.TabIndex = 5;
            this.botonImagen.Text = "Cargar imagen";
            this.botonImagen.UseVisualStyleBackColor = true;
            this.botonImagen.Click += new System.EventHandler(this.botonImagen_Click);
            this.botonImagen.MouseLeave += new System.EventHandler(this.salir);
            this.botonImagen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // etiquetaImagen
            // 
            this.etiquetaImagen.AutoSize = true;
            this.etiquetaImagen.Location = new System.Drawing.Point(435, 187);
            this.etiquetaImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etiquetaImagen.Name = "etiquetaImagen";
            this.etiquetaImagen.Size = new System.Drawing.Size(0, 15);
            this.etiquetaImagen.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Click += new System.EventHandler(this.cargar);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botonSalir;
            this.ClientSize = new System.Drawing.Size(798, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.etiquetaImagen);
            this.Controls.Add(this.botonImagen);
            this.Controls.Add(this.botonColor);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.botonSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(814, 482);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(814, 482);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.cargar);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button botonSalir;
        private TextBox color1;
        private TextBox color3;
        private TextBox color2;
        private Button botonColor;
        private Button botonImagen;
        private Label etiquetaImagen;
        private TextBox textoImagen;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}