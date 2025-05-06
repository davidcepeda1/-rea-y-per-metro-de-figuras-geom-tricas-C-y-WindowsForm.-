using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    class Rectangulo
    {
        //Ancho del rectangulo
        private float mWidth;
        //Largo del rectangulo
        private float mHeight;
        //Perimetro del rectangulo
        private float mPerimeter;
        //Area del rectangulo
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Rectangulo()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del rectangulo
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


        //Funcion que calcula el perimetro del rectangulo
        public void PerimeterRectangle()
        {
            mPerimeter = 2 * mWidth + 2 * mHeight;  
        }

        //Funcion que calcula el area de rectangulo
        public void AreaRectangle()
        {
            mArea = mWidth * mHeight;
        }

        //Funcion que imprime el perimetro y el area del rectangulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del rectangulo
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
        //Funcion que grafica un rectangulo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rectangulo
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
