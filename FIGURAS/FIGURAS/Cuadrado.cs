using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    internal class Cuadrado
    {
        //Lado del cuadrado
        private float mSide;
        //Perimetro del cuadrado
        private float mPerimeter;
        //Area del cuadrado
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
        private Pen mPen;

        //Constructor sin parametros
        public Cuadrado()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del cuadrado
        public void ReadData(TextBox txtSide)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSide.Text))
                    throw new Exception("El campo no puede estar vacío.");

                mSide = float.Parse(txtSide.Text);

                if (mSide <= 0)
                    throw new Exception("El valor debe ser mayor que cero.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido.", "Error de formato");
                mSide = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada");
                mSide = 0;
            }
        }


        //Funcion que calcula el perimetro del cuadrado
        public void PerimeterSquare()
        {
            mPerimeter = 4 * mSide;
        }

        //Funcion que calcula el area de cuadrado
        public void AreaSquare()
        {
            mArea = mSide * mSide;
        }

        //Funcion que imprime el perimetro y el area del cuadrado
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion para inicializar los datos y controles del cuadrado
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
        //Funcion que grafica un cuadrado
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un cuadrado
            mGraph.DrawRectangle(mPen, 0, 0, mSide * SF, mSide * SF);
        }

        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

