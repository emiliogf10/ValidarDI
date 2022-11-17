namespace Ejercicio4
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.RadioButton();
            this.restar = new System.Windows.Forms.RadioButton();
            this.multiplicar = new System.Windows.Forms.RadioButton();
            this.dividir = new System.Windows.Forms.RadioButton();
            this.operacion = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sumar
            // 
            this.sumar.AutoSize = true;
            this.sumar.Location = new System.Drawing.Point(233, 47);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(33, 19);
            this.sumar.TabIndex = 2;
            this.sumar.TabStop = true;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.CheckedChanged += new System.EventHandler(this.sumar_CheckedChanged);
            // 
            // restar
            // 
            this.restar.AutoSize = true;
            this.restar.Location = new System.Drawing.Point(297, 47);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(30, 19);
            this.restar.TabIndex = 3;
            this.restar.TabStop = true;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.CheckedChanged += new System.EventHandler(this.sumar_CheckedChanged);
            // 
            // multiplicar
            // 
            this.multiplicar.AutoSize = true;
            this.multiplicar.Location = new System.Drawing.Point(233, 110);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(30, 19);
            this.multiplicar.TabIndex = 4;
            this.multiplicar.TabStop = true;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.CheckedChanged += new System.EventHandler(this.sumar_CheckedChanged);
            // 
            // dividir
            // 
            this.dividir.AutoSize = true;
            this.dividir.Location = new System.Drawing.Point(297, 110);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(30, 19);
            this.dividir.TabIndex = 5;
            this.dividir.TabStop = true;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.CheckedChanged += new System.EventHandler(this.sumar_CheckedChanged);
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(92, 82);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(0, 15);
            this.operacion.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(92, 82);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 15);
            this.label.TabIndex = 10;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(92, 223);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(73, 15);
            this.resultado.TabIndex = 11;
            this.resultado.Text = "Resultado = ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 258);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private RadioButton sumar;
        private RadioButton restar;
        private RadioButton multiplicar;
        private RadioButton dividir;
        private Label operacion;
        private Label label;
        private Label resultado;
        private System.Windows.Forms.Timer timer1;
    }
}