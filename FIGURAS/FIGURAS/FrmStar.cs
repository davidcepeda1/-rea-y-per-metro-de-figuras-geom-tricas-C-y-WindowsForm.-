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
    public partial class FrmStar : Form
    {
        private Estrella ObjStar = new Estrella();
        public FrmStar()
        {
            InitializeComponent();
        }

        private void FrmStar_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjStar.InitializeData(txtRadiusEx, txtRadiusIn, txtVertex, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjStar.ReadData(txtRadiusEx, txtRadiusIn, txtVertex);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjStar.PerimeterStar();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjStar.AreaStar();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjStar.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjStar.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjStar.InitializeData(txtRadiusEx, txtRadiusIn, txtVertex, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjStar.CloseForm(this);
        }
    }
}
