namespace FIGURAS
{
    partial class FrmTriangle
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
            this.txtSide = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
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
            this.gpGrafico.Location = new System.Drawing.Point(388, 32);
            this.gpGrafico.Name = "gpGrafico";
            this.gpGrafico.Size = new System.Drawing.Size(527, 365);
            this.gpGrafico.TabIndex = 14;
            this.gpGrafico.TabStop = false;
            this.gpGrafico.Text = "Grafico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(23, 28);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(481, 311);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // gpProceso
            // 
            this.gpProceso.Controls.Add(this.btnExit);
            this.gpProceso.Controls.Add(this.btnReset);
            this.gpProceso.Controls.Add(this.btnCalculate);
            this.gpProceso.Location = new System.Drawing.Point(15, 162);
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
            this.gpSalida.Location = new System.Drawing.Point(14, 280);
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
            this.gbEntradas.Controls.Add(this.txtSide);
            this.gbEntradas.Controls.Add(this.lblLado);
            this.gbEntradas.Location = new System.Drawing.Point(14, 32);
            this.gbEntradas.Name = "gbEntradas";
            this.gbEntradas.Size = new System.Drawing.Size(351, 108);
            this.gbEntradas.TabIndex = 11;
            this.gbEntradas.TabStop = false;
            this.gbEntradas.Text = "Entradas";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(108, 55);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(208, 22);
            this.txtSide.TabIndex = 2;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(35, 58);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(41, 16);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado:";
            // 
            // FrmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(926, 419);
            this.Controls.Add(this.gpGrafico);
            this.Controls.Add(this.gpProceso);
            this.Controls.Add(this.gpSalida);
            this.Controls.Add(this.gbEntradas);
            this.Name = "FrmTriangle";
            this.Text = "FrmTriangle";
            this.Load += new System.EventHandler(this.FrmTriangle_load);
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
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblLado;
    }
}