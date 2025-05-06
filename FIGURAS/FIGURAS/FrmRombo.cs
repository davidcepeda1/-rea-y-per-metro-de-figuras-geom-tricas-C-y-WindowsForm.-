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
    public partial class FrmRombo : Form
    {
        private Rombo ObjRombo = new Rombo();
        public FrmRombo()
        {
            InitializeComponent();
        }

        private void lblMayor_Click(object sender, EventArgs e)
        {

        }
        private void FrmRombo_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjRombo.InitializeData(txtMax, txtMin, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjRombo.ReadData(txtMax, txtMin);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjRombo.PerimeterRombo();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjRombo.AreaRombo();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjRombo.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjRombo.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjRombo.InitializeData(txtMax, txtMin, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjRombo.CloseForm(this);
        }
    }
}
