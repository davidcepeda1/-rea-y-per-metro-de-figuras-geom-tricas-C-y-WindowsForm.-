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
    public partial class FrmTrapezoid : Form
    {
        private Trapezoide ObjTrapezoid = new Trapezoide();
        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void FrmTrapezoid_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjTrapezoid.InitializeData(txtMax, txtMin, txtHeight, txtLeft, txtRight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjTrapezoid.ReadData(txtMax, txtMin, txtLeft, txtRight, txtHeight);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjTrapezoid.PerimeterTrapezoid();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjTrapezoid.AreaTrapezoid();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjTrapezoid.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjTrapezoid.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjTrapezoid.InitializeData(txtMax, txtMin, txtHeight, txtLeft, txtRight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjTrapezoid.CloseForm(this);
        }
    }
}
