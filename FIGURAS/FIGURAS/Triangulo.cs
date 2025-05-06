using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Triangulo
    {
        //Lado del triangulo
        private float mSide;
        //Perimetro del triangulo
        private float mPerimeter;
        //Area del triangulo
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Triangulo()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del triangulo
        public void ReadData(TextBox txtSide)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSide.Text))
                    throw new Exception("El campo del lado no puede estar vacío.");

                mSide = float.Parse(txtSide.Text);

                if (mSide <= 0)
                    throw new Exception("El lado debe ser mayor que cero.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error de formato");
                mSide = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mSide = 0;
            }
        }

        //Funcion que calcula el perimetro del triangulo
        public void PerimeterTriangle()
        {
            mPerimeter = 3 * mSide;
        }

        //Funcion que calcula el area de triangulo
        public void AreaTriangle()
        {
            mArea = (float)((Math.Sqrt(3) / 4) * mSide * mSide);
        }

        //Funcion que imprime el perimetro y el area del triangulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del triangulo
        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtSide.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un triangulo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un triangulo
            float height = (float)(Math.Sqrt(3) / 2 * mSide * SF);

            // Definir puntos del triángulo
            PointF[] trianglePoints = new PointF[3];
            float centerX = picCanvas.Width / 2;
            float topY = 20;

            trianglePoints[0] = new PointF(centerX, topY); // vértice superior
            trianglePoints[1] = new PointF(centerX - (mSide * SF) / 2, topY + height); // vértice inferior izquierdo
            trianglePoints[2] = new PointF(centerX + (mSide * SF) / 2, topY + height); // vértice inferior derecho

            // Dibujar el triángulo
            mGraph.DrawPolygon(mPen, trianglePoints);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
}
}
