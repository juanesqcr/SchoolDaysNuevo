namespace SchoolDays.UI.Vistas
{
    partial class ListaNotas
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
            this.btn_MostrarProfesor = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaNota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNota)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MostrarProfesor
            // 
            this.btn_MostrarProfesor.Location = new System.Drawing.Point(723, 442);
            this.btn_MostrarProfesor.Name = "btn_MostrarProfesor";
            this.btn_MostrarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btn_MostrarProfesor.TabIndex = 12;
            this.btn_MostrarProfesor.Text = "Mostrar";
            this.btn_MostrarProfesor.UseVisualStyleBackColor = true;
            this.btn_MostrarProfesor.Click += new System.EventHandler(this.btn_MostrarProfesor_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(83, 41);
            this.txtCedula.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(291, 20);
            this.txtCedula.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cedula:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(380, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Notas por estudiante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvListaNota
            // 
            this.dgvListaNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaNota.Location = new System.Drawing.Point(22, 68);
            this.dgvListaNota.Name = "dgvListaNota";
            this.dgvListaNota.Size = new System.Drawing.Size(776, 368);
            this.dgvListaNota.TabIndex = 7;
            // 
            // ListaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(810, 500);
            this.Controls.Add(this.btn_MostrarProfesor);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaNotas";
            this.Text = "ListaNotas";
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MostrarProfesor;
        private System.Windows.Forms.NumericUpDown txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaNota;
    }
}