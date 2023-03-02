using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;

namespace Ejercicio2
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    public partial class UserControl1 : Control
    {
        public UserControl1()
        {
            InitializeComponent();

        }

        private bool gradiente = false;
        [Category("Appearance")]
        [Description("True para mostrar el gradiente y false para no mostrarlo")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }
        private Color color1;
        [Category("Appearance")]
        [Description("Primer color para el gradiente")]
        public Color Color1
        {
            set
            {
                color1 = value;
                this.Refresh();
            }
            get
            {
                return color1;
            }
        }

        private Color color2;
        [Category("Appearance")]
        [Description("Segundo color para el gradiente")]
        public Color Color2
        {
            set
            {
                color2 = value;
                this.Refresh();
            }
            get
            {
                return color2;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }



        private eMarca marca = eMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia 
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (Gradiente)
            {
                LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(this.Width, 0),
                color1,
                color2);

                Rectangle rt = new Rectangle(0, 0, this.Width, this.Height);
                g.FillRectangle(linGrBrush, rt);
                linGrBrush.Dispose();


            }



            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se 
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (imagenMarca != null)
                    {
                        g.DrawImage(imagenMarca, new Rectangle(0, 0, this.FontHeight, this.FontHeight));
                    }
                    break;
            }

            if (Marca == eMarca.Imagen && eMarca.Imagen != null)
            {
                //Finalmente pintamos el Texto; desplazado si fuera necesario
                SolidBrush b = new SolidBrush(this.ForeColor);
                g.DrawString(this.Text, this.Font, b, offsetX + grosor + this.FontHeight, offsetY);
                Size tam = g.MeasureString(this.Text, this.Font).ToSize();
                this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
                b.Dispose();
            }
            else
            {
                //Finalmente pintamos el Texto; desplazado si fuera necesario
                SolidBrush b = new SolidBrush(this.ForeColor);
                g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
                Size tam = g.MeasureString(this.Text, this.Font).ToSize();
                this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
                b.Dispose();

            }





        }

        private Image imagenMarca;
        [Category("Appearance")]
        [Description("Indica la imagen que llevará el componente")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }

        [Category("Appearance")]
        [Description("Se lanza cuando se hace click en donde está la marca")]

        public event System.EventHandler ClickEnMarca;

        protected virtual void OnClickMarca(EventArgs e)
        {
            ClickEnMarca?.Invoke(this, e);
        }

        private void click_en_marca(object sender, EventArgs e)
        {
            OnClickMarca(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            click_en_marca(this, e);
        }
    }
}
