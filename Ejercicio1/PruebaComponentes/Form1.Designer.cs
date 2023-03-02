namespace PruebaComponentes
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbltxtbox = new Ejercicio1.UserControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltxtbox
            // 
            this.lbltxtbox.Location = new System.Drawing.Point(25, 31);
            this.lbltxtbox.Name = "lbltxtbox";
            this.lbltxtbox.Posicion = Ejercicio1.ePosicion.IZQUIERDA;
            this.lbltxtbox.PswChr = '*';
            this.lbltxtbox.Separacion = 200;
            this.lbltxtbox.Size = new System.Drawing.Size(392, 20);
            this.lbltxtbox.TabIndex = 0;
            this.lbltxtbox.TextLbl = "label1";
            this.lbltxtbox.TextTxt = "";
            this.lbltxtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbltxtbox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio1.UserControl1 lbltxtbox;
        private System.Windows.Forms.Button button1;
    }
}

