using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Elipse
    {
        //Ancho del elipse
        private float mWidth;
        //Largo del elipse
        private float mHeight;
        //Perimetro del elipse
        private float mPerimeter;
        //Area del elipse
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Elipse()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del elipse
        public void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtWidth.Text) || string.IsNullOrWhiteSpace(txtHeight.Text))
                    throw new Exception("Todos los campos deben estar llenos.");

                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mWidth <= 0 || mHeight <= 0)
                    throw new Exception("Los valores deben ser mayores que cero.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo valores numéricos.", "Error de formato");
                mWidth = mHeight = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mWidth = mHeight = 0;
            }
        }


        //Funcion que calcula el perimetro del elipse
        public void PerimeterElipse()
        {
            float h = (float)Math.Pow((mWidth - mHeight), 2) / (float)Math.Pow((mWidth + mHeight), 2);
            mPerimeter = (float)(Math.PI * (mWidth + mHeight) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }

        //Funcion que calcula el area de elipse
        public void AreaElipse()
        {
            mArea = (float)(Math.PI * mWidth * mHeight);
        }

        //Funcion que imprime el perimetro y el area del elipse
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del elipse
        public void InitializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtWidth.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtWidth.Focus();
            picCanvas.Refresh();
        }
        //Funcion que grafica un elipse
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un elipse
            float width = 2 * mWidth * SF;
            float height = 2 * mHeight * SF;

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            mGraph.DrawEllipse(mPen, centerX - width / 2, centerY - height / 2, width, height);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
