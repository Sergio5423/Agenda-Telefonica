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

namespace PresentacionForm
{
    public partial class FormContactoFamiliar : Form
    {
        ServicioContactoFamiliar servicioContactoFamiliar = new ServicioContactoFamiliar();

        public FormContactoFamiliar()
        {
            InitializeComponent();
        }

        private void FormContactoFamiliar_Load(object sender, EventArgs e)
        {
            CargarLista();
            llenarGridView();
            llenarGridView2();
            //llenarGridView3(txtFiltro.Text);
            Filtrar(txtFiltro.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {            
            tbId.Text = servicioContactoFamiliar.UltimoId().ToString();           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Capturar();
            Limpiar();
            CargarLista();
        }        

        private void lstFamiliar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lista = servicioContactoFamiliar.GetAll();
            int i = lstFamiliar.SelectedIndex;
            tbId.Text = lista[i].Id.ToString();
            tbNombre.Text = lista[i].Nombre.ToString();  
            tbTelefono.Text = lista[i].Telefono;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarLista();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Capturar();
            Limpiar();
            Eliminar();
            CargarLista();
        }

        public void Limpiar()
        {
            tbId.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbTelefono.Text = string.Empty;
        }

        public void Capturar()
        {
            var contacto = new ContactoFamiliar();

            contacto.Id = int.Parse(tbId.Text);
            contacto.Nombre = tbNombre.Text;
            contacto.Telefono = tbTelefono.Text;
            contacto.FechaNacimiento = dtpFecha.Value;
            var msg = servicioContactoFamiliar.Add(contacto);
            tbId.Focus();
            dtpFecha.Value = DateTime.Now;
        }

        public void CargarLista()
        {
            lstFamiliar.Items.Clear();
            var lista = servicioContactoFamiliar.GetAll();
            foreach (var item in lista)
            {
                lstFamiliar.Items.Add(item.Nombre);
            }
        }

        public void Eliminar()
        {
            servicioContactoFamiliar.Eliminar(lstFamiliar.Text);            
        }
        
        public void llenarGridView()
        {
            foreach (var item in servicioContactoFamiliar.GetAll())
            {
                gridViewCF.Rows.Add(item.Id, item.Nombre, item.Telefono, item.FechaNacimiento);
            }
        }

        public void llenarGridView2()
        {
            gridViewCF2.DataSource = servicioContactoFamiliar.GetAllDto();
        }
        BindingSource bin = new BindingSource();
        public void llenarGridView3(string filtro)
        {
            //var bl = servicioContactoFamiliar.ListaEspecial();
            //bl.Where(x => x.Nombre.Contains(txtFiltro.Text));
            //bin.DataSource = bl;
            //¿bin.Filter? ¿como se usa?
            //grilla3.DataSource = bin;
        }
        void Filtrar(string filtro)
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar(txtFiltro.Text);
        }
    }
}