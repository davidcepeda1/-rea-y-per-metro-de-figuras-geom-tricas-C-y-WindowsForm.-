using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Trapezoide
    {
        //Base mayor del trapecio
        private float mMax;
        //Base menor del trapecio
        private float mMin;
        //Altura del trapecio
        private float mHeight;
        //Lado Izquierdo del trapecio
        private float mLeft;
        //Lado Derecho del trapecio
        private float mRight;
        //Perimetro del trapecio
        private float mPerimeter;
        //Area del trapecio
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 10;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Trapezoide()
        {
            mMax = 0.0f; mMin = 0.0f; mLeft = 0.0f; mRight = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del trapecio
        public void ReadData(TextBox txtMax, TextBox txtMin, TextBox txtHeight, TextBox txtLeft, TextBox txtRight)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMax.Text) ||
                    string.IsNullOrWhiteSpace(txtMin.Text) ||
                    string.IsNullOrWhiteSpace(txtHeight.Text) ||
                    string.IsNullOrWhiteSpace(txtLeft.Text) ||
                    string.IsNullOrWhiteSpace(txtRight.Text))
                    throw new Exception("Todos los campos deben estar llenos.");

                mMax = float.Parse(txtMax.Text);
                mMin = float.Parse(txtMin.Text);
                mHeight = float.Parse(txtHeight.Text);
                mLeft = float.Parse(txtLeft.Text);
                mRight = float.Parse(txtRight.Text);

                if (mMax <= 0 || mMin <= 0 || mHeight <= 0 || mLeft <= 0 || mRight <= 0)
                    throw new Exception("Todos los valores deben ser mayores que cero.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error de formato");
                mMax = mMin = mHeight = mLeft = mRight = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mMax = mMin = mHeight = mLeft = mRight = 0;
            }
        }

        //Funcion que calcula el perimetro del trapecio
        public void PerimeterTrapezoid()
        {
            mPerimeter = mMax + mMin + mLeft + mRight;
        }

        //Funcion que calcula el area de trapecio
        public void AreaTrapezoid()
        {
            mArea = ((mMax + mMin) * mHeight) / 2;
        }

        //Funcion que imprime el perimetro y el area del trapecio
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del trapecio
        public void InitializeData(TextBox txtMax, TextBox txtMin, TextBox txtHeight, TextBox txtLeft, TextBox txtRight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mMax = 0.0f; mMin = 0.0f; mLeft = 0.0f; mRight = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtMax.Text = ""; txtMin.Text = ""; txtHeight.Text = "";
            txtLeft.Text = ""; txtRight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtMax.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un trapecio
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un trapecio
            float baseMayor = mMax * SF;
            float baseMenor = mMin * SF;
            float altura = mHeight * SF;

            float xCenter = picCanvas.Width / 2;
            float yStart = picCanvas.Height / 2;

            float dx1 = (float)Math.Sqrt(Math.Max(0, mLeft * mRight - mHeight * mHeight)) * SF;
            float dx2 = (float)Math.Sqrt(Math.Max(0, mRight * mRight - mHeight * mHeight)) * SF;

            PointF p1 = new PointF(xCenter - baseMayor / 2, yStart);
            PointF p2 = new PointF(xCenter + baseMayor / 2, yStart);
            PointF p3 = new PointF(xCenter + baseMenor / 2 - dx2, yStart - altura);
            PointF p4 = new PointF(xCenter - baseMenor / 2 + dx1, yStart - altura);

            PointF[] trapezoide = { p1, p2, p3, p4 };
            mGraph.DrawPolygon(mPen, trapezoide);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
