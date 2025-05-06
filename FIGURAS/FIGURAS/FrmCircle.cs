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
    public partial class FrmCircle : Form
    {
        private Circulo ObjCircle = new Circulo();
        public FrmCircle()
        {
            InitializeComponent();
        }

        private void FrmCircle_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjCircle.ReadData(txtRadius);
            //Calculo del perimetro de un Circulo
            //Llamada a la funcion PerimeterCircle
            ObjCircle.PerimeterCircle();
            //Calculo del area de un Circulo
            //Llamada a la funcion AreaCircle
            ObjCircle.AreaCircle();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjCircle.PrintData(txtPerimeter, txtArea);
            //Graficacion de un Circulo
            //Llamada a la funcion PlotShape
            ObjCircle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles
            //Llamada a la funcion InitializeData
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjCircle.CloseForm(this);
        }
    }
}
