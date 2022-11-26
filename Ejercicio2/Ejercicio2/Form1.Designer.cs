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
            this.botonSalir.Location = new System.Drawing.Point(326, 653);
            this.botonSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(474, 38);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            this.botonSalir.MouseLeave += new System.EventHandler(this.salir);
            this.botonSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(49, 152);
            this.color1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(190, 31);
            this.color1.TabIndex = 0;
            this.color1.Click += new System.EventHandler(this.cargar);
            this.color1.Enter += new System.EventHandler(this.color1_Enter);
            // 
            // color3
            // 
            this.color3.Location = new System.Drawing.Point(534, 152);
            this.color3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(220, 31);
            this.color3.TabIndex = 2;
            this.color3.Click += new System.EventHandler(this.cargar);
            this.color3.Enter += new System.EventHandler(this.color1_Enter);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(294, 152);
            this.color2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(203, 31);
            this.color2.TabIndex = 1;
            this.color2.Click += new System.EventHandler(this.cargar);
            this.color2.Enter += new System.EventHandler(this.color1_Enter);
            // 
            // botonColor
            // 
            this.botonColor.Location = new System.Drawing.Point(846, 148);
            this.botonColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonColor.Name = "botonColor";
            this.botonColor.Size = new System.Drawing.Size(163, 38);
            this.botonColor.TabIndex = 3;
            this.botonColor.Text = "Color";
            this.botonColor.UseVisualStyleBackColor = true;
            this.botonColor.Click += new System.EventHandler(this.botonColor_Click);
            this.botonColor.MouseLeave += new System.EventHandler(this.salir);
            this.botonColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // botonImagen
            // 
            this.botonImagen.Location = new System.Drawing.Point(296, 335);
            this.botonImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonImagen.Name = "botonImagen";
            this.botonImagen.Size = new System.Drawing.Size(203, 38);
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
            this.etiquetaImagen.Location = new System.Drawing.Point(621, 312);
            this.etiquetaImagen.Name = "etiquetaImagen";
            this.etiquetaImagen.Size = new System.Drawing.Size(0, 25);
            this.etiquetaImagen.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(534, 260);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 335);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Click += new System.EventHandler(this.cargar);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botonSalir;
            this.ClientSize = new System.Drawing.Size(1134, 722);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1156, 778);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1156, 778);
            this.Name = "Form1";
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