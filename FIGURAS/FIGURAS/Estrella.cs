using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Estrella
    {
        //Radio externo de estrella
        private float mRadiusEx;
        //Radio interno de estrella
        private float mRadiusIn;
        //Altura del estrella
        private int mVertex;
        //Perimetro del estrella
        private float mPerimeter;
        //Area del estrella
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 10;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Estrella()
        {
            mRadiusEx = 0.0f; mRadiusIn = 0.0f; mVertex = 0;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del estrella
        public void ReadData(TextBox txtRadiusEx, TextBox txtRadiusIn, TextBox txtVertex)
        {
            try
            {
                mRadiusEx = float.Parse(txtRadiusEx.Text);
                mRadiusIn = float.Parse(txtRadiusIn.Text);
                mVertex = int.Parse(txtVertex.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...",
                                "Mensaje de error");
            }
        }

        //Funcion que calcula el perimetro del estrella
        public void PerimeterStar()
        {
            double R = mRadiusEx;
            double r = mRadiusIn;
            int n = mVertex;

            // Lado entre puntos extremos (aproximado)
            double lado = Math.Sqrt(R * R + r * r - 2 * R * r * Math.Cos(Math.PI / n));

            mPerimeter = (float)(2 * n * lado);
        }

        //Funcion que calcula el area de estrella
        public void AreaStar()
        {
            double r = mRadiusIn;
            double R = mRadiusEx;
            int n = mVertex;

            // Área del pentágono interior
            double areaPentagono = (n / 2.0) * r * r * Math.Sin(2 * Math.PI / n);

            // Área de las puntas (n triángulos)
            double baseTriangulo = 2 * R * Math.Sin(Math.PI / n);
            double alturaTriangulo = R - r;
            double areaTriangulos = n * 0.5 * baseTriangulo * alturaTriangulo;

            mArea = (float)(areaPentagono + areaTriangulos);
        }

        //Funcion que imprime el perimetro y el area del estrella
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del estrella
        public void InitializeData(TextBox txtRadiusEx, TextBox txtRadiusIn, TextBox txtVertex, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadiusEx = 0.0f; mRadiusIn = 0.0f; mVertex = 0;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtRadiusEx.Text = ""; txtRadiusIn.Text = ""; txtVertex.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtRadiusEx.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un estrella
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un estrella
            float cx = 150;
            float cy = 150;

            List<PointF> puntos = new List<PointF>();
            double angulo = -Math.PI / 2; // Comienza apuntando hacia arriba
            double paso = Math.PI / mVertex;

            for (int i = 0; i < mVertex * 2; i++)
            {
                float radio = (i % 2 == 0) ? mRadiusEx * SF : mRadiusIn * SF;
                float x = cx + (float)(Math.Cos(angulo) * radio);
                float y = cy + (float)(Math.Sin(angulo) * radio);
                puntos.Add(new PointF(x, y));
                angulo += paso;
            }

            mGraph.DrawPolygon(mPen, puntos.ToArray());
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
