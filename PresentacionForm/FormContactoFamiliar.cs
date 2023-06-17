using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace PresentacionForm
{
    public partial class FormContactoFamiliar : Form
    {
        ServicioContactoFamiliar servicioContactoFamiliar = new ServicioContactoFamiliar();
        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FuenteDeVideo;
        private string path;
        private int Id;

        public FormContactoFamiliar()
        {
            InitializeComponent();
        }

        private void FormContactoFamiliar_Load(object sender, EventArgs e)
        {
            llenarComboBoxCamaras();
            llenarGridView();
            llenarGridView2();
            llenarGridView3();
            //Filtrar(txtFiltro.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            ApagarCamara();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbId.Text = servicioContactoFamiliar.UltimoId().ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Capturar();
            Limpiar();
            llenarGridView3();
            ApagarCamara();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            Limpiar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar(txtFiltro.Text);
        }

        public void Limpiar()
        {
            tbId.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbTelefono.Text = string.Empty;
        }

        public void Actualizar()
        {
            var contacto = new ContactoFamiliar();

            contacto.Id = int.Parse(tbId.Text);
            contacto.Nombre = tbNombre.Text;
            contacto.Telefono = tbTelefono.Text;
            contacto.FechaCumpleaños = dtpFecha.Value;
            GuardarImagen(tbId.Text);
            contacto.Ruta = path + tbId.Text;
            servicioContactoFamiliar.Actualizar(contacto);
            tbId.Focus();
            dtpFecha.Value = DateTime.Now;
        }

        public void Capturar()
        {
            var contacto = new ContactoFamiliar
            {
                Id = int.Parse(tbId.Text),
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                FechaCumpleaños = dtpFecha.Value
            };            
            contacto.Ruta = path + tbId.Text;
            var msg = servicioContactoFamiliar.Add(contacto);
            GuardarImagen(tbId.Text);
            tbId.Focus();
            dtpFecha.Value = DateTime.Now;
        }

        //public void CargarLista()
        //{
        //    lstFamiliar.Items.Clear();
        //    var lista = servicioContactoFamiliar.GetAll();
        //    foreach (var item in lista)
        //    {
        //        lstFamiliar.Items.Add(item.Nombre);
        //    }
        //}

        //public void Eliminar()
        //{
        //    servicioContactoFamiliar.Eliminar(lstFamiliar.Text);            
        //}
    
        public void llenarGridView()
        {
            var lista = servicioContactoFamiliar.GetAll();
            if (lista == null)
            {

            } else
            {
                foreach (var item in lista)
                {
                    gridViewCF.Rows.Add(item.Id, item.Nombre, item.Telefono, item.FechaCumpleaños);
                }
            }            
        }

        public void llenarGridView2()
        {
            gridViewCF2.DataSource = servicioContactoFamiliar.GetAllDto();
        }

        BindingSource bin = new BindingSource();

        public void llenarGridView3()
        { 
            BindingSource bin = new BindingSource();
            bin.DataSource = servicioContactoFamiliar.GetAll();
            grilla3.DataSource = bin;
            //var bl = servicioContactoFamiliar.ListaEspecial();
            //bl.Where(x => x.Nombre.Contains(txtFiltro.Text));
            //bin.DataSource = bl;
            //¿bin.Filter? ¿como se usa?
            //grilla3.DataSource = bin;
        }

        public void Filtrar(string filtro)
        {
            grilla3.DataSource = null;
            var bl = servicioContactoFamiliar.ListaEspecial();
            
            bin.DataSource = bl.Where(x => x.Nombre.Contains(txtFiltro.Text));
            //bin.SupportsFiltering = true;
            //bin.Filter = string.Format("Nombre like '%{0}%'", txtFiltro.Text);
            grilla3.DataSource = bin;
            //grilla3.Update();
            //grilla3.Refresh();
        }

        public void llenarComboBoxCamaras()
        {
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Dispositivo in Dispositivos)
            {
                cbCamaras.Items.Add(Dispositivo.Name);
            }
            cbCamaras.SelectedIndex = 0;
        }

        public void IniciarImagen()
        {
            ApagarCamara();
            int i = cbCamaras.SelectedIndex;
            string NombreVideo = Dispositivos[i].MonikerString;
            FuenteDeVideo = new VideoCaptureDevice(NombreVideo);
            FuenteDeVideo.NewFrame += new NewFrameEventHandler(Capturando);
            FuenteDeVideo.Start();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbImage.Image = Imagen;
        }

        private void ApagarCamara()
        {
            if (FuenteDeVideo != null && FuenteDeVideo.IsRunning)
            {
                FuenteDeVideo.SignalToStop();
                FuenteDeVideo = null;
            }
        }

        private void Eliminar()
        {
            servicioContactoFamiliar.EliminarBD(Id);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarImagen();
        }

        private void FormContactoFamiliar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ApagarCamara();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            ApagarCamara();
        }

        private void GuardarImagen(string id)
        {
            pbImage.Image.Save(path + $"{id}.jpg", ImageFormat.Jpeg);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            path = AbrirArchivo() + @"\";
        }

        string AbrirArchivo()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();            
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = folderBrowserDialog.SelectedPath;
                return ruta;
            }
            return string.Empty;
        }

        private void grilla3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = int.Parse(grilla3.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            llenarGridView3();
        }
    }
}