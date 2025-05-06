using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Circulo
    {
        //Radio del circulo
        private float mRadius;
        //Perimetro del circulo
        private float mPerimeter;
        //Area del circulo
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Circulo()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del circulo
        public void ReadData(TextBox txtSide)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSide.Text))
                    throw new Exception("El campo no puede estar vacío.");

                mRadius = float.Parse(txtSide.Text);

                if (mRadius <= 0)
                    throw new Exception("El valor debe ser mayor que cero.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido.", "Error de formato");
                mRadius = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mRadius = 0;
            }
        }


        //Funcion que calcula el perimetro del circulo
        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        //Funcion que calcula el area de circulo
        public void AreaCircle()
        {
            mArea = (float)Math.PI * mRadius * mRadius;
        }

        //Funcion que imprime el perimetro y el area del circulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del circulo
        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtSide.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un circulo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un circulo
            float diameter = mRadius * 2 * SF;
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Dibujar el círculo centrado
            mGraph.DrawEllipse(mPen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
