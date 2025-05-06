using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIGURAS
{
    public partial class FrmRectangulo : Form
    {
        //Definicion de un objeto de tipo Rectangle
        private Rectangulo ObjRectangulo = new Rectangulo();
        public FrmRectangulo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjRectangulo.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjRectangulo.ReadData(txtWidth, txtHeight);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjRectangulo.PerimeterRectangle();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjRectangulo.AreaRectangle();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjRectangulo.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjRectangulo.PlotShape(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles
            //Llamada a la funcion InitializeData
            ObjRectangulo.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjRectangulo.CloseForm(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjRectangulo.ReadData(txtWidth, txtHeight);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjRectangulo.PerimeterRectangle();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjRectangulo.AreaRectangle();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjRectangulo.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjRectangulo.PlotShape(picCanvas);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles
            //Llamada a la funcion InitializeData
            ObjRectangulo.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjRectangulo.CloseForm(this);
        }
    }
}
