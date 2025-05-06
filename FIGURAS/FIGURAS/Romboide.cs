using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Romboide
    {
        //Base del romboide
        private float mBase;
        //Altura del romboide
        private float mHeight;
        //Angulo del romboide
        private float mAngle;
        //Perimetro del romboide
        private float mPerimeter;
        //Area del romboide
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 10;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Romboide()
        {
            mBase = 0.0f; mHeight = 0.0f; mAngle = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del romboide
        public void ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtAngle)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBase.Text) ||
                    string.IsNullOrWhiteSpace(txtHeight.Text) ||
                    string.IsNullOrWhiteSpace(txtAngle.Text))
                    throw new Exception("Todos los campos deben estar llenos.");

                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
                mAngle = float.Parse(txtAngle.Text);

                if (mBase <= 0 || mHeight <= 0)
                    throw new Exception("La base y la altura deben ser mayores que cero.");

                if (mAngle <= 0 || mAngle >= 180)
                    throw new Exception("El ángulo debe estar entre 0° y 180° (exclusivo).");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo valores numéricos.", "Error de formato");
                mBase = mHeight = mAngle = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mBase = mHeight = mAngle = 0;
            }
        }

        //Funcion que calcula el perimetro del romboide
        public void PerimeterRomboide()
        {
            // Calcular lado inclinado usando trigonometría
            float ladoInclinado = mHeight / (float)Math.Sin(mAngle * Math.PI / 180.0);
            mPerimeter = 2 * (mBase + ladoInclinado);
        }

        //Funcion que calcula el area de romboide
        public void AreaRomboide()
        {
            mArea = mBase * mHeight;
        }

        //Funcion que imprime el perimetro y el area del romboide
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del romboide
        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtAngle, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase = 0.0f; mHeight = 0.0f; mAngle = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtBase.Text = ""; txtHeight.Text = ""; txtAngle.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtBase.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un romboide
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un romboide
            float rad = mAngle * (float)Math.PI / 180.0f;
            float desplazamientoX = mHeight / (float)Math.Tan(rad);

            // Crear 4 puntos: A, B, C, D (ordenados en sentido horario)
            PointF A = new PointF(50, 200);
            PointF B = new PointF(50 + mBase * SF, 200);
            PointF C = new PointF(B.X + desplazamientoX * SF, 200 - mHeight * SF);
            PointF D = new PointF(A.X + desplazamientoX * SF, 200 - mHeight * SF);

            PointF[] puntos = { A, B, C, D };
            mGraph.DrawPolygon(mPen, puntos);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
