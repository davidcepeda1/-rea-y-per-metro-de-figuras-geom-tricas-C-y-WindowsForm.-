namespace FIGURAS
{
    partial class FrmTrapezoid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpGrafico = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.gpProceso = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gpSalida = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.gbEntradas = new System.Windows.Forms.GroupBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.lblDerecho = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.lblIzquierdo = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.gpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.gpProceso.SuspendLayout();
            this.gpSalida.SuspendLayout();
            this.gbEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpGrafico
            // 
            this.gpGrafico.Controls.Add(this.picCanvas);
            this.gpGrafico.Location = new System.Drawing.Point(381, 12);
            this.gpGrafico.Name = "gpGrafico";
            this.gpGrafico.Size = new System.Drawing.Size(565, 463);
            this.gpGrafico.TabIndex = 14;
            this.gpGrafico.TabStop = false;
            this.gpGrafico.Text = "Grafico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(23, 28);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(519, 409);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // gpProceso
            // 
            this.gpProceso.Controls.Add(this.btnExit);
            this.gpProceso.Controls.Add(this.btnReset);
            this.gpProceso.Controls.Add(this.btnCalculate);
            this.gpProceso.Location = new System.Drawing.Point(8, 236);
            this.gpProceso.Name = "gpProceso";
            this.gpProceso.Size = new System.Drawing.Size(350, 99);
            this.gpProceso.TabIndex = 13;
            this.gpProceso.TabStop = false;
            this.gpProceso.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(136, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 25);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 48);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 25);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gpSalida
            // 
            this.gpSalida.Controls.Add(this.txtArea);
            this.gpSalida.Controls.Add(this.txtPerimeter);
            this.gpSalida.Controls.Add(this.lblArea);
            this.gpSalida.Controls.Add(this.lblPerimetro);
            this.gpSalida.Location = new System.Drawing.Point(8, 358);
            this.gpSalida.Name = "gpSalida";
            this.gpSalida.Size = new System.Drawing.Size(351, 117);
            this.gpSalida.TabIndex = 12;
            this.gpSalida.TabStop = false;
            this.gpSalida.Text = "Entradas";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(108, 69);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(208, 22);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(108, 37);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(208, 22);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(38, 72);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(35, 40);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // gbEntradas
            // 
            this.gbEntradas.Controls.Add(this.txtRight);
            this.gbEntradas.Controls.Add(this.lblDerecho);
            this.gbEntradas.Controls.Add(this.txtLeft);
            this.gbEntradas.Controls.Add(this.lblIzquierdo);
            this.gbEntradas.Controls.Add(this.txtMax);
            this.gbEntradas.Controls.Add(this.lblMayor);
            this.gbEntradas.Controls.Add(this.txtHeight);
            this.gbEntradas.Controls.Add(this.txtMin);
            this.gbEntradas.Controls.Add(this.lblAltura);
            this.gbEntradas.Controls.Add(this.lblMenor);
            this.gbEntradas.Location = new System.Drawing.Point(7, 12);
            this.gbEntradas.Name = "gbEntradas";
            this.gbEntradas.Size = new System.Drawing.Size(351, 206);
            this.gbEntradas.TabIndex = 11;
            this.gbEntradas.TabStop = false;
            this.gbEntradas.Text = "Entradas";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(108, 178);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(208, 22);
            this.txtRight.TabIndex = 9;
            // 
            // lblDerecho
            // 
            this.lblDerecho.AutoSize = true;
            this.lblDerecho.Location = new System.Drawing.Point(6, 178);
            this.lblDerecho.Name = "lblDerecho";
            this.lblDerecho.Size = new System.Drawing.Size(96, 16);
            this.lblDerecho.TabIndex = 8;
            this.lblDerecho.Text = "Lado Derecho:";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(108, 140);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(208, 22);
            this.txtLeft.TabIndex = 7;
            this.txtLeft.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIzquierdo
            // 
            this.lblIzquierdo.AutoSize = true;
            this.lblIzquierdo.Location = new System.Drawing.Point(3, 140);
            this.lblIzquierdo.Name = "lblIzquierdo";
            this.lblIzquierdo.Size = new System.Drawing.Size(99, 16);
            this.lblIzquierdo.TabIndex = 6;
            this.lblIzquierdo.Text = "Lado Izquierdo:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(108, 28);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(208, 22);
            this.txtMax.TabIndex = 5;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(19, 28);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(83, 16);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Base mayor:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(108, 102);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(208, 22);
            this.txtHeight.TabIndex = 3;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(108, 65);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(208, 22);
            this.txtMin.TabIndex = 2;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(58, 105);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(44, 16);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(19, 65);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(83, 16);
            this.lblMenor.TabIndex = 0;
            this.lblMenor.Text = "Base menor:";
            // 
            // FrmTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(973, 501);
            this.Controls.Add(this.gpGrafico);
            this.Controls.Add(this.gpProceso);
            this.Controls.Add(this.gpSalida);
            this.Controls.Add(this.gbEntradas);
            this.Name = "FrmTrapezoid";
            this.Text = "FrmTrapezoid";
            this.Load += new System.EventHandler(this.FrmTrapezoid_load);
            this.gpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.gpProceso.ResumeLayout(false);
            this.gpSalida.ResumeLayout(false);
            this.gpSalida.PerformLayout();
            this.gbEntradas.ResumeLayout(false);
            this.gbEntradas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpGrafico;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox gpProceso;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gpSalida;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox gbEntradas;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label lblDerecho;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label lblIzquierdo;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblMenor;
    }
}