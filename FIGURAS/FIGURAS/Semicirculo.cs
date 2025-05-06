using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Semicirculo
    {
        //Radio del semicirculo
        private float mRadius;
        //Perimetro del semicirculo
        private float mPerimeter;
        //Area del semicirculo
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Semicirculo()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del semicirculo
        public void ReadData(TextBox txtSide)
        {
            try
            {
                mRadius = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...",
                                "Mensaje de error");
            }
        }

        //Funcion que calcula el perimetro del semicirculo
        public void PerimeterSemicircle()
        {
            mPerimeter = (float)(Math.PI * mRadius) + (2 * mRadius);
        }

        //Funcion que calcula el area de semicirculo
        public void AreaSemicircle()
        {
            mArea = (float)((Math.PI * mRadius * mRadius) / 2);
        }

        //Funcion que imprime el perimetro y el area del semicirculo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del semicirculo
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
        //Funcion que grafica un semicirculo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un semicirculo
            float diameter = 2 * mRadius * SF;
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Dibujar semicírculo superior (180° desde 0 a 180 grados)
            mGraph.DrawPie(mPen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter, 0, 180);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
