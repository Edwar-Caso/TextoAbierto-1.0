using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidadesTextoAbierto;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.IO;
using System.Drawing.Imaging;

namespace TextoAbierto
{
    public partial class TextoAbiertoCrear : Form
    {
        public TextoAbiertoCrear()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Autentificacion de la base de datos en la nube, con FireBase
        /// </summary>
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "FhXmCLLu1tunV9tTEFOlJmWsKs7Kc4mRDM3u4qJ4",
            BasePath = "https://textoabierto-3fb1a-default-rtdb.firebaseio.com/"
        }; // Wilder Autrentificar la base de datos

        IFirebaseClient client;

        //Evento click para cerrar la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento click para minimizar la ventana del formulario
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar codigo aleatorio
            Random codigoAleatorio = new Random();
            int intervalo = codigoAleatorio.Next(10000, 99999);
            String interv = Convert.ToString(intervalo);
            lblCodigo.Text = interv;

            //insertar imagen
            MemoryStream flujoMemoria = new MemoryStream();
            boxImagen.Image.Save(flujoMemoria, ImageFormat.Jpeg);

            byte[] array = flujoMemoria.GetBuffer();
            string salida = Convert.ToBase64String(array);
            var dato = new Cuestionario
            {
                imagen = salida
            };
            //Cuestionario.imagen = salida;

            FirebaseResponse respuesta = await client.GetAsync("contador/nodo");
            datosFirebase obtenerDato = respuesta.ResultAs<datosFirebase>();

            //Almacenar datos a firebase
            var cuestion = new Cuestionario()
            {

                id = (Convert.ToInt32(obtenerDato.cont) + 1).ToString(),
                numeroAleatorio = lblCodigo.Text,
                pregunta = txtPregunta.Text,
                descripcion = txtDescripcion.Text,
                imagen = Convert.ToBase64String(array)  
            };
            SetResponse response = await client.SetAsync("Cuestionario/" + lblCodigo.Text, cuestion);
            Cuestionario resultado = response.ResultAs<Cuestionario>();
            
            var obj = new datosFirebase
            {
                cont = (Convert.ToInt32(obtenerDato.cont) +1).ToString()
            };
            SetResponse response1 = await client.SetAsync("contador/nodo", obj);

            MessageBox.Show("Ingreso de datos satisfactorio");

            //mostrar en la pantalla
            lblMostrarPregunta.Text = txtPregunta.Text;
            lblMostrarDescripcion.Text = txtDescripcion.Text;
            pictBoxMostrarIm.Image = boxImagen.Image;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Profesor frm = new Profesor();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Abrir ventana de crear
            TextoAbiertoCrear frm = new TextoAbiertoCrear();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            //Abrir ventana de presentacion
            TextoAbiertoPresentación frm = new TextoAbiertoPresentación();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //Abrir ventana de reporte
            TextoAbiertoReporte frm = new TextoAbiertoReporte();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //subir un archivo
            OpenFileDialog selecionaImagen = new OpenFileDialog();
            selecionaImagen.Title = "Selecionar Imagen";
            selecionaImagen.Filter = "Imagenes|*.jpg;*png";
            selecionaImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if(openFileImage.ShowDialog()==DialogResult.OK)
            boxImagen.Image = Image.FromFile(openFileImage.FileName);
        }

        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextoAbiertoCrear_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Tienes problemas con la conexion a internet, verifique su conexion");
            }
        } //wilder error de conexion a internet

        private void boxImagen_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbldCodigo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
