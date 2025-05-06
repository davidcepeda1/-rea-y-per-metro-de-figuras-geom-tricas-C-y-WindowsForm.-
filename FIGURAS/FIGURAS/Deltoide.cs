using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Deltoide
    {
        //Diagonal mayor del deltoide
        private float mMax;
        //Diagonal menor del deltoide
        private float mMin;
        //Lado largo
        private float mSideL;
        //Lado corto
        private float mSideS;
        //Perimetro del deltoide
        private float mPerimeter;
        //Area del deltoide
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 10;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Deltoide()
        {
            mMax = 0.0f; mMin = 0.0f; mSideL = 0.0f; mSideS = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del deltoide
        public void ReadData(TextBox txtMax, TextBox txtMin, TextBox txtSideL, TextBox txtSideS)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtMax.Text) ||
                    string.IsNullOrWhiteSpace(txtMin.Text) ||
                    string.IsNullOrWhiteSpace(txtSideL.Text) ||
                    string.IsNullOrWhiteSpace(txtSideS.Text))
                {
                    throw new Exception("Todos los campos deben estar llenos.");
                }

                // Parseo
                mMax = float.Parse(txtMax.Text);
                mMin = float.Parse(txtMin.Text);
                mSideL = float.Parse(txtSideL.Text);
                mSideS = float.Parse(txtSideS.Text);

                // Validaciones numéricas
                if (mMax <= 0 || mMin <= 0 || mSideL <= 0 || mSideS <= 0)
                {
                    throw new Exception("Todos los valores deben ser mayores que cero.");
                }

                if (mMax == mMin)
                {
                    throw new Exception("Las diagonales deben ser diferentes en un deltoide.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo valores numéricos.", "Error de formato");
                mMax = mMin = mSideL = mSideS = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mMax = mMin = mSideL = mSideS = 0;
            }
        }


        //Funcion que calcula el perimetro del deltoide
        public void PerimeterDeltoide()
        {
            float ladoLargo = (float)Math.Sqrt(Math.Pow(mMax / 2, 2) + Math.Pow(mSideL, 2));
            float ladoCorto = (float)Math.Sqrt(Math.Pow(mMax / 2, 2) + Math.Pow(mSideS, 2));
            mPerimeter = 2 * ladoLargo + 2 * ladoCorto;
        }

        //Funcion que calcula el area de deltoide
        public void AreaDeltoide()
        {
            mArea = (mMax * mMin) / 2;
        }

        //Funcion que imprime el perimetro y el area del deltoide
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del deltoide
        public void InitializeData(TextBox txtMax, TextBox txtMin, TextBox txtSideL, TextBox txtSideS, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mMax = 0.0f; mMin = 0.0f; mSideL = 0.0f; mSideS = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtMax.Text = ""; txtMin.Text = ""; txtSideL.Text = ""; txtSideS.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtMax.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un deltoide
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un deltoide
            float cx = 150;
            float cy = 150;

            PointF arriba = new PointF(cx, cy - mSideL * SF);
            PointF abajo = new PointF(cx, cy + mSideS * SF);
            PointF izquierda = new PointF(cx - (mMax / 2) * SF, cy);
            PointF derecha = new PointF(cx + (mMax / 2) * SF, cy);

            PointF[] puntos = { arriba, derecha, abajo, izquierda };
            mGraph.DrawPolygon(mPen, puntos);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
