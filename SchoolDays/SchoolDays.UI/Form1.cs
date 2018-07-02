﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SchoolDays.UI.Vistas;

namespace SchoolDays.UI
{
    public partial class Form1 : Form
    {

        #region Metodos 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
        }
        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }


        #endregion

        #region Metodos Botones superiores

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        #endregion

        #region Metodos Menu Vertical

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirForm(new MenuPrincipal());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Botones par reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (panelSubMenuReportes.Visible == true)
            {
                panelSubMenuReportes.Visible = false;
            }
            else
            {
                panelSubMenuReportes.Visible = true;
            };
        }
        private void btnGraduados_Click(object sender, EventArgs e)
        {
            panelSubMenuReportes.Visible = false;
        }

        private void btnReporteEstudianteGrado_Click(object sender, EventArgs e)
        {
            panelSubMenuReportes.Visible = false;
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            btnReporte.Visible = false;
        }
        #endregion

        #region Botones de Alumno

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            if (panelAlumnos.Visible == true)
            {
                panelAlumnos.Visible = false;
            }
            else
            {
                panelAlumnos.Visible = true;
            }

        }
        private void btnAgrgarAlumnos_Click(object sender, EventArgs e)
        {
            panelAlumnos.Visible = false;
            AbrirForm(new Alumnos());
        }

        private void btnListaAlumnos_Click(object sender, EventArgs e)
        {
            AbrirForm(new ListaAlumnos());
        }
        #endregion

        #region botones profesor

        private void BtnProfesor_Click(object sender, EventArgs e)
        {
            AbrirForm(new Profesor());

        }
        #endregion

        #endregion

        #region Metodo para mostrar en el panel

        private void AbrirForm(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        #endregion

        #region Metodos para mover pantalla

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void ii(object sender, FormClosedEventArgs e)
        {

        }


    }
}
