using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Rombo
    {
        //Base mayor del rombo
        private float mMax;
        //Base menor del rombo
        private float mMin;
        //Perimetro del rombo
        private float mPerimeter;
        //Area del rombo
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 10;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Rombo()
        {
            mMax = 0.0f; mMin = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del rombo
        public void ReadData(TextBox txtMax, TextBox txtMin)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMax.Text) || string.IsNullOrWhiteSpace(txtMin.Text))
                    throw new Exception("Todos los campos deben estar llenos.");

                mMax = float.Parse(txtMax.Text);
                mMin = float.Parse(txtMin.Text);

                if (mMax <= 0 || mMin <= 0)
                    throw new Exception("Las diagonales deben ser mayores que cero.");

                if (mMax == mMin)
                    throw new Exception("Las diagonales deben ser diferentes para un rombo.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo valores numéricos.", "Error de formato");
                mMax = mMin = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mMax = mMin = 0;
            }
        }


        //Funcion que calcula el perimetro del rombo
        public void PerimeterRombo()
        {
            float l = (float)Math.Sqrt(Math.Pow(mMax / 2, 2) + Math.Pow(mMin / 2, 2));
            mPerimeter = 4 * l;
        }

        //Funcion que calcula el area de rombo
        public void AreaRombo()
        {
            mArea = (mMax * mMin) / 2;
        }

        //Funcion que imprime el perimetro y el area del rombo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del rombo
        public void InitializeData(TextBox txtMax, TextBox txtMin, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mMax = 0.0f; mMin = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtMax.Text = ""; txtMin.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtMax.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un rombo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rombo
            float xCenter = picCanvas.Width / 2;
            float yCenter = picCanvas.Height / 2;

            float halfD = (mMax * SF) / 2;
            float halfd = (mMin * SF) / 2;

            PointF p1 = new PointF(xCenter, yCenter - halfD); // Arriba
            PointF p2 = new PointF(xCenter + halfd, yCenter); // Derecha
            PointF p3 = new PointF(xCenter, yCenter + halfD); // Abajo
            PointF p4 = new PointF(xCenter - halfd, yCenter); // Izquierda

            PointF[] rombo = { p1, p2, p3, p4 };
            mGraph.DrawPolygon(mPen, rombo);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
