namespace SchoolDays.UI.Vistas
{
    partial class Notas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProfesor = new System.Windows.Forms.ComboBox();
            this.txtNombreAlumno = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.ComboBox();
            this.txtGrado = new System.Windows.Forms.ComboBox();
            this.txttercerParcial = new System.Windows.Forms.NumericUpDown();
            this.txtPrimerParcial = new System.Windows.Forms.NumericUpDown();
            this.txtSegundoParcial = new System.Windows.Forms.NumericUpDown();
            this.txtTrabajoCotidiano = new System.Windows.Forms.NumericUpDown();
            this.txtTareas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txttercerParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegundoParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrabajoCotidiano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignar Nota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(377, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Profesor:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(242, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del alumno:";
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.FormattingEnabled = true;
            this.txtNombreProfesor.Items.AddRange(new object[] {
            "Matematicas",
            "Sociales",
            "Español",
            "Ciencias"});
            this.txtNombreProfesor.Location = new System.Drawing.Point(519, 100);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(186, 21);
            this.txtNombreProfesor.TabIndex = 12;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.FormattingEnabled = true;
            this.txtNombreAlumno.Items.AddRange(new object[] {
            "Profesor nuevo",
            "Profesor con experiencia",
            "Profesor Experto"});
            this.txtNombreAlumno.Location = new System.Drawing.Point(377, 56);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(186, 21);
            this.txtNombreAlumno.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(630, 276);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Materia:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(464, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Grado:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(396, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Trabajo cotidiano:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(458, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tareas:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(83, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tercer Parcial:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(68, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Segundo Parcial:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(84, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Primer Parcial:";
            // 
            // txtMateria
            // 
            this.txtMateria.FormattingEnabled = true;
            this.txtMateria.Location = new System.Drawing.Point(185, 100);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(186, 21);
            this.txtMateria.TabIndex = 23;
            // 
            // txtGrado
            // 
            this.txtGrado.FormattingEnabled = true;
            this.txtGrado.Items.AddRange(new object[] {
            "Matematicas",
            "Sociales",
            "Español",
            "Ciencias"});
            this.txtGrado.Location = new System.Drawing.Point(519, 141);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(186, 21);
            this.txtGrado.TabIndex = 24;
            // 
            // txttercerParcial
            // 
            this.txttercerParcial.Location = new System.Drawing.Point(185, 217);
            this.txttercerParcial.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txttercerParcial.Name = "txttercerParcial";
            this.txttercerParcial.Size = new System.Drawing.Size(186, 20);
            this.txttercerParcial.TabIndex = 25;
            // 
            // txtPrimerParcial
            // 
            this.txtPrimerParcial.Location = new System.Drawing.Point(185, 142);
            this.txtPrimerParcial.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtPrimerParcial.Name = "txtPrimerParcial";
            this.txtPrimerParcial.Size = new System.Drawing.Size(186, 20);
            this.txtPrimerParcial.TabIndex = 26;
            // 
            // txtSegundoParcial
            // 
            this.txtSegundoParcial.Location = new System.Drawing.Point(185, 178);
            this.txtSegundoParcial.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtSegundoParcial.Name = "txtSegundoParcial";
            this.txtSegundoParcial.Size = new System.Drawing.Size(186, 20);
            this.txtSegundoParcial.TabIndex = 27;
            // 
            // txtTrabajoCotidiano
            // 
            this.txtTrabajoCotidiano.Location = new System.Drawing.Point(519, 182);
            this.txtTrabajoCotidiano.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtTrabajoCotidiano.Name = "txtTrabajoCotidiano";
            this.txtTrabajoCotidiano.Size = new System.Drawing.Size(186, 20);
            this.txtTrabajoCotidiano.TabIndex = 28;
            // 
            // txtTareas
            // 
            this.txtTareas.Location = new System.Drawing.Point(519, 217);
            this.txtTareas.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtTareas.Name = "txtTareas";
            this.txtTareas.Size = new System.Drawing.Size(186, 20);
            this.txtTareas.TabIndex = 29;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTareas);
            this.Controls.Add(this.txtTrabajoCotidiano);
            this.Controls.Add(this.txtSegundoParcial);
            this.Controls.Add(this.txtPrimerParcial);
            this.Controls.Add(this.txttercerParcial);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreProfesor);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notas";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.txttercerParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegundoParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrabajoCotidiano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtNombreProfesor;
        private System.Windows.Forms.ComboBox txtNombreAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtMateria;
        private System.Windows.Forms.ComboBox txtGrado;
        private System.Windows.Forms.NumericUpDown txttercerParcial;
        private System.Windows.Forms.NumericUpDown txtPrimerParcial;
        private System.Windows.Forms.NumericUpDown txtSegundoParcial;
        private System.Windows.Forms.NumericUpDown txtTrabajoCotidiano;
        private System.Windows.Forms.NumericUpDown txtTareas;
    }
}