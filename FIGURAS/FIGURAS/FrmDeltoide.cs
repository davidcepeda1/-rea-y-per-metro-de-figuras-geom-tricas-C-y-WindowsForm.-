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
    public partial class FrmDeltoide : Form
    {
        private Deltoide ObjDeltoide = new Deltoide();
        public FrmDeltoide()
        {
            InitializeComponent();
        }

        private void FrmDeltoide_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjDeltoide.InitializeData(txtMax, txtMin, txtSideL, txtSideS, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjDeltoide.ReadData(txtMax, txtMin, txtSideS, txtSideL);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjDeltoide.PerimeterDeltoide();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjDeltoide.AreaDeltoide();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjDeltoide.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjDeltoide.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjDeltoide.InitializeData(txtMax, txtMin, txtSideL, txtSideS, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjDeltoide.CloseForm(this);
        }
    }
}
