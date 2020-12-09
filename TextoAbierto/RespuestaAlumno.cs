using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextoAbierto
{
    public partial class RespuestaAlumno : Form
    {
        public RespuestaAlumno()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviarRespuesta_Click(object sender, EventArgs e)
        {
            Notificatición frm = new Notificatición();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
