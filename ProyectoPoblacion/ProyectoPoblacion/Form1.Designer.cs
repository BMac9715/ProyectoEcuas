namespace ProyectoPoblacion
{
    partial class Form1
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
            this.dgvPoblacion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGráfica = new System.Windows.Forms.Button();
            this.btnCiclo = new System.Windows.Forms.Button();
            this.picGráfica = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lbEjeX = new System.Windows.Forms.Label();
            this.lbEjeY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoblacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGráfica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoblacion
            // 
            this.dgvPoblacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoblacion.ColumnHeadersVisible = false;
            this.dgvPoblacion.Location = new System.Drawing.Point(12, 12);
            this.dgvPoblacion.Name = "dgvPoblacion";
            this.dgvPoblacion.RowHeadersVisible = false;
            this.dgvPoblacion.Size = new System.Drawing.Size(403, 403);
            this.dgvPoblacion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnGráfica);
            this.groupBox1.Controls.Add(this.btnCiclo);
            this.groupBox1.Location = new System.Drawing.Point(12, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnGráfica
            // 
            this.btnGráfica.Location = new System.Drawing.Point(172, 47);
            this.btnGráfica.Name = "btnGráfica";
            this.btnGráfica.Size = new System.Drawing.Size(101, 23);
            this.btnGráfica.TabIndex = 1;
            this.btnGráfica.Text = "Generar Gráfica";
            this.btnGráfica.UseVisualStyleBackColor = true;
            this.btnGráfica.Click += new System.EventHandler(this.btnGráfica_Click);
            // 
            // btnCiclo
            // 
            this.btnCiclo.Location = new System.Drawing.Point(29, 47);
            this.btnCiclo.Name = "btnCiclo";
            this.btnCiclo.Size = new System.Drawing.Size(101, 23);
            this.btnCiclo.TabIndex = 0;
            this.btnCiclo.Text = "Siguiente Ciclo";
            this.btnCiclo.UseVisualStyleBackColor = true;
            this.btnCiclo.Click += new System.EventHandler(this.btnCiclo_Click);
            // 
            // picGráfica
            // 
            this.picGráfica.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picGráfica.Location = new System.Drawing.Point(520, 12);
            this.picGráfica.Name = "picGráfica";
            this.picGráfica.Size = new System.Drawing.Size(430, 430);
            this.picGráfica.TabIndex = 2;
            this.picGráfica.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(315, 47);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(101, 23);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // lbEjeX
            // 
            this.lbEjeX.AutoSize = true;
            this.lbEjeX.Location = new System.Drawing.Point(915, 442);
            this.lbEjeX.Name = "lbEjeX";
            this.lbEjeX.Size = new System.Drawing.Size(35, 13);
            this.lbEjeX.TabIndex = 3;
            this.lbEjeX.Text = "Ciclos";
            // 
            // lbEjeY
            // 
            this.lbEjeY.AutoSize = true;
            this.lbEjeY.Location = new System.Drawing.Point(421, 12);
            this.lbEjeY.Name = "lbEjeY";
            this.lbEjeY.Size = new System.Drawing.Size(95, 13);
            this.lbEjeY.TabIndex = 4;
            this.lbEjeY.Text = "Población enferma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 551);
            this.Controls.Add(this.lbEjeY);
            this.Controls.Add(this.lbEjeX);
            this.Controls.Add(this.picGráfica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPoblacion);
            this.Name = "Form1";
            this.Text = "Población Enfermos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoblacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGráfica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPoblacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCiclo;
        private System.Windows.Forms.Button btnGráfica;
        private System.Windows.Forms.PictureBox picGráfica;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lbEjeX;
        private System.Windows.Forms.Label lbEjeY;
    }
}

