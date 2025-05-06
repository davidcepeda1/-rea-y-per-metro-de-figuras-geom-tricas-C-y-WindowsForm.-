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
    public partial class FrmRomboide : Form
    {
        private Romboide ObjRomboide = new Romboide();
        public FrmRomboide()
        {
            InitializeComponent();
        }

        private void FrmRomboide_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjRomboide.InitializeData(txtBase, txtHeight, txtAngle, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjRomboide.ReadData(txtBase, txtHeight, txtAngle);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjRomboide.PerimeterRomboide();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjRomboide.AreaRomboide();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjRomboide.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            ObjRomboide.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjRomboide.InitializeData(txtBase, txtHeight, txtAngle, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjRomboide.CloseForm(this);
        }
    }
}
