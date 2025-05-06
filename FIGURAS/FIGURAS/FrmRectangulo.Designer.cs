namespace FIGURAS
{
    partial class FrmRectangulo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbEntradas = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.gpSalida = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.gpProceso = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gpGrafico = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.gbEntradas.SuspendLayout();
            this.gpSalida.SuspendLayout();
            this.gpProceso.SuspendLayout();
            this.gpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEntradas
            // 
            this.gbEntradas.Controls.Add(this.txtHeight);
            this.gbEntradas.Controls.Add(this.txtWidth);
            this.gbEntradas.Controls.Add(this.lblLargo);
            this.gbEntradas.Controls.Add(this.lblAncho);
            this.gbEntradas.Location = new System.Drawing.Point(23, 25);
            this.gbEntradas.Name = "gbEntradas";
            this.gbEntradas.Size = new System.Drawing.Size(351, 155);
            this.gbEntradas.TabIndex = 0;
            this.gbEntradas.TabStop = false;
            this.gbEntradas.Text = "Entradas";
            this.gbEntradas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(108, 87);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(208, 22);
            this.txtHeight.TabIndex = 3;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(108, 55);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(208, 22);
            this.txtWidth.TabIndex = 2;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(38, 90);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(64, 16);
            this.lblLargo.TabIndex = 1;
            this.lblLargo.Text = "Largo (a):";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(35, 58);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(67, 16);
            this.lblAncho.TabIndex = 0;
            this.lblAncho.Text = "Ancho (a):";
            this.lblAncho.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpSalida
            // 
            this.gpSalida.Controls.Add(this.txtArea);
            this.gpSalida.Controls.Add(this.txtPerimeter);
            this.gpSalida.Controls.Add(this.lblArea);
            this.gpSalida.Controls.Add(this.lblPerimetro);
            this.gpSalida.Location = new System.Drawing.Point(23, 326);
            this.gpSalida.Name = "gpSalida";
            this.gpSalida.Size = new System.Drawing.Size(351, 117);
            this.gpSalida.TabIndex = 4;
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
            // gpProceso
            // 
            this.gpProceso.Controls.Add(this.btnExit);
            this.gpProceso.Controls.Add(this.btnReset);
            this.gpProceso.Controls.Add(this.btnCalculate);
            this.gpProceso.Location = new System.Drawing.Point(23, 204);
            this.gpProceso.Name = "gpProceso";
            this.gpProceso.Size = new System.Drawing.Size(350, 99);
            this.gpProceso.TabIndex = 5;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(136, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 25);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 48);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 25);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // gpGrafico
            // 
            this.gpGrafico.Controls.Add(this.picCanvas);
            this.gpGrafico.Location = new System.Drawing.Point(397, 25);
            this.gpGrafico.Name = "gpGrafico";
            this.gpGrafico.Size = new System.Drawing.Size(527, 417);
            this.gpGrafico.TabIndex = 6;
            this.gpGrafico.TabStop = false;
            this.gpGrafico.Text = "Grafico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(23, 28);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(481, 361);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // FrmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(951, 466);
            this.Controls.Add(this.gpGrafico);
            this.Controls.Add(this.gpProceso);
            this.Controls.Add(this.gpSalida);
            this.Controls.Add(this.gbEntradas);
            this.Name = "FrmRectangulo";
            this.Text = "FrmRectangulo";
            this.Load += new System.EventHandler(this.FrmRectangle_Load);
            this.gbEntradas.ResumeLayout(false);
            this.gbEntradas.PerformLayout();
            this.gpSalida.ResumeLayout(false);
            this.gpSalida.PerformLayout();
            this.gpProceso.ResumeLayout(false);
            this.gpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntradas;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.GroupBox gpSalida;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox gpProceso;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gpGrafico;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}

