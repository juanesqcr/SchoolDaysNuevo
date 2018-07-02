using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDays.UI.Vistas
{
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(eventoTimer);
            timer.Enabled = true;

            InitializeComponent();
        }

        #region metodo para el reloj y fecha
        private Timer timer;

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lblReloj.Text = hoy.ToString("hh:mm:ss zzz");
            lblFecha.Text = hoy.ToString("dd-MMMM-yy");
        }

        #endregion
        private void lblReloj_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
