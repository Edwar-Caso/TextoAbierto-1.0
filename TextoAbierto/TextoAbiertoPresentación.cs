using CapaEntidadesTextoAbierto;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class TextoAbiertoPresentación : Form
    {
        DataTable dt = new DataTable();

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "FhXmCLLu1tunV9tTEFOlJmWsKs7Kc4mRDM3u4qJ4",
            BasePath = "https://textoabierto-3fb1a-default-rtdb.firebaseio.com/"
        }; // Wilder Autrentificar la base de datos

        IFirebaseClient client;

        public TextoAbiertoPresentación()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            Presentacion frm = new Presentacion();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Editar fmr = new Editar();
            fmr.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            TextoAbiertoCrear frm = new TextoAbiertoCrear();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Profesor frm = new Profesor();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            TextoAbiertoPresentación frm = new TextoAbiertoPresentación();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            TextoAbiertoReporte frm = new TextoAbiertoReporte();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void TextoAbiertoPresentación_Load(object sender, EventArgs e)
        {
        }

        private async Task export()
        {
            int i = 0;
            FirebaseResponse resp = await client.GetAsync("contador/nodo");
   
            datosFirebase objeto = resp.ResultAs<datosFirebase>();

            int cnt = Convert.ToInt32(objeto.cont);
             while(true)
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse respues = await client.GetAsync("Cuestionario/" + i);
                    Cuestionario objeto2 = respues.ResultAs<Cuestionario>();
                /*
                    DataRow row = dt.NewRow();
                    row["ID"] = objeto2.id;
                    row["CODIGO"] = objeto2.numeroAleatorio;
                    row["PREGUNTA"] = objeto2.pregunta;
                    row["DESCRIPCION"] = objeto2.descripcion;
                    row["IMAGEN"] = objeto2.imagen;

                    dt.Rows.Add(row);
                */
                /*
                this.dataGridViewPresentacion.Rows[0].Cells[0].Value = Cuestionario.id;
                this.dataGridViewPresentacion.Rows[0].Cells[0].Value = Cuestionario.numeroAleatorio;
                this.dataGridViewPresentacion.Rows[0].Cells[0].Value = Cuestionario.pregunta;
                this.dataGridViewPresentacion.Rows[0].Cells[0].Value = Cuestionario.descripcion;
                this.dataGridViewPresentacion.Rows[0].Cells[0].Value = Cuestionario.imagen;
                */
                }
                catch
                {

                }

            MessageBox.Show("Listo");

        }
    }
}
