using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace FIGURAS
{
    public partial class FrmSquare : Form
    {
        //Definicion de un objeto de tipo Rectangle
        private Cuadrado ObjSquare = new Cuadrado();
        public FrmSquare()
        {
            InitializeComponent();
        }

        private void FrmSquare_load(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjSquare.ReadData(txtSide);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjSquare.PerimeterSquare();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjSquare.AreaSquare();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjSquare.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjSquare.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles
            //Llamada a la funcion InitializeData
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjSquare.CloseForm(this);
        }
    }
}
