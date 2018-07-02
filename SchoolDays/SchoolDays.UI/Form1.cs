using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SchoolDays.UI
{
    public partial class Form1 : Form
    {

        #region Metodos x
        public Form1()
        {
            InitializeComponent();
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnNormal.Visible = false;
        }

        #endregion

        #region Metodos Menu Vertical

        #region Metodos Menu y Submenu Reportes

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelSubMenuReportes.Visible = true;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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



    }
}
