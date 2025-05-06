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
    public partial class FrmTrapeze : Form
    {
        private Trapecio ObjTrapeze = new Trapecio();
        public FrmTrapeze()
        {
            InitializeComponent();
        }

        private void lblMayor_Click(object sender, EventArgs e)
        {
        }

        private void FrmTrapeze_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjTrapeze.InitializeData(txtMax, txtMin, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjTrapeze.ReadData(txtMax, txtMin, txtHeight);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjTrapeze.PerimeterTrapeze();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjTrapeze.AreaTrapeze();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjTrapeze.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjTrapeze.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjTrapeze.InitializeData(txtMax, txtMin, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjTrapeze.CloseForm(this);
        }
    }
}
