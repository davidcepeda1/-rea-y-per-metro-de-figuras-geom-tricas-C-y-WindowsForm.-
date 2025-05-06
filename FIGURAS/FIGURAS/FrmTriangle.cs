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
    public partial class FrmTriangle : Form
    {
        private Triangulo ObjTriangulo = new Triangulo();
        public FrmTriangle()
        {
            InitializeComponent();
        }

        private void FrmTriangle_load(object sender, EventArgs e)
        {
            //Inicializacion de los datos y controloes
            //Lamada a la funcion IniatilizeData
            ObjTriangulo.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjTriangulo.ReadData(txtSide);
            //Calculo del perimetro de un Triangulo
            //Llamada a la funcion PerimeterTriangle
            ObjTriangulo.PerimeterTriangle();
            //Calculo del area de un Triangulo
            //Llamada a la funcion AreaTriangle
            ObjTriangulo.AreaTriangle();
            //Impresion de datos
            //LLamada a la funcion PrintData
            ObjTriangulo.PrintData(txtPerimeter, txtArea);
            //Graficacion de un Triangulo
            //Llamada a la funcion PlotShape
            ObjTriangulo.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles
            //Llamada a la funcion InitializeData
            ObjTriangulo.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierre de un formulario
            //LLamada a la funcion CloseForm
            ObjTriangulo.CloseForm(this);
        }
    }
}
