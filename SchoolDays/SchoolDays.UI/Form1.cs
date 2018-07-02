using System;
using System.Windows.Forms;

namespace SchoolDays.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Metodos Botones superiores

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
