using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using System.IO;
using System.Drawing.Imaging;
using FireSharp.Response;
using FireSharp.Config;
using CapaEntidadesTextoAbierto;

namespace TextoAbierto
{
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }
      /*  IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "K4VmddybmsiaIJu9lm74lnZZop2jsHo2Wo3pwrbf",
            BasePath = "https://textoabierto-ee6c6-default-rtdb.firebaseio.com/"
        }; // Wilder Autrentificar la base de datos

        IFirebaseClient client;*/

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextoAbiertoCrear frm = new TextoAbiertoCrear();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pRESENTACIÒNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para presentar
            /*var resultado = client.Get("Cuestionario/");
            Cuestionario cuest = resultado.ResultAs<Cuestionario>();    */       

            TextoAbiertoPresentación frm = new TextoAbiertoPresentación();
            frm.MdiParent = this;
            frm.Show();

            
        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextoAbiertoReporte frm = new TextoAbiertoReporte();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Profesor_Load(object sender, EventArgs e)
        {

        }
    }
}
