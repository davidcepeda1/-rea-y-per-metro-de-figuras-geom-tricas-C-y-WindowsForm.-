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
    public partial class FrmSemiCircle : Form
    {
        private Semicirculo ObjSemiCircle = new Semicirculo();
        public FrmSemiCircle()
        {
            InitializeComponent();
        }

        private void FrmSemiCircle_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjSemiCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjSemiCircle.ReadData(txtRadius);
            //Calculo del perimetro de un Circulo
            //Llamada a la funcion PerimeterCircle
            ObjSemiCircle.PerimeterSemicircle();
            //Calculo del area de un Circulo
            //Llamada a la funcion AreaCircle
            ObjSemiCircle.AreaSemicircle();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjSemiCircle.PrintData(txtPerimeter, txtArea);
            //Graficacion de un Circulo
            //Llamada a la funcion PlotShape
            ObjSemiCircle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjSemiCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjSemiCircle.CloseForm(this);
        }
    }
}
