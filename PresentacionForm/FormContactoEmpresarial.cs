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
    public partial class FormContactoEmpresarial : Form
    {
        ServicioContactoEmpresarial servicioContactoEmpresarial = new ServicioContactoEmpresarial();
        public FormContactoEmpresarial()
        {
            InitializeComponent();
        }

        private void FormContactoEmpresarial_Load(object sender, EventArgs e)
        {
            CargarLista();
            LlenarGridView();
            LlenarGridView2();
            LlenarGridView3();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Capturar();
            Limpiar();
            CargarLista();
        }

        private void lstEmpresarial_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lista = servicioContactoEmpresarial.GetAll();
            int i = lstEmpresarial.SelectedIndex;
            tbId.Text = lista[i].Id.ToString();
            tbNombre.Text = lista[i].Nombre.ToString();
            tbTelefono.Text = lista[i].Telefono;
            tbEmpresa.Text = lista[i].NombreEmpresa;
            tbCorreo.Text = lista[i].Correo;
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
            tbEmpresa.Text = string.Empty;
            tbCorreo.Text = string.Empty; 
        }

        public void Capturar()
        {
            var contacto = new ContactoEmpresarial();

            contacto.Id = int.Parse(tbId.Text);
            contacto.Nombre = tbNombre.Text;
            contacto.Telefono = tbTelefono.Text;
            contacto.NombreEmpresa = tbEmpresa.Text;
            contacto.Correo = tbCorreo.Text;
            var msg = servicioContactoEmpresarial.Add(contacto);
            tbId.Focus();
        }

        public void CargarLista()
        {
            lstEmpresarial.Items.Clear();
            var lista = servicioContactoEmpresarial.GetAll();
            foreach (var item in lista)
            {
                lstEmpresarial.Items.Add(item.Nombre);
            }
        }

        public void Eliminar()
        {
            servicioContactoEmpresarial.Eliminar(lstEmpresarial.Text);
        }

        public void LlenarGridView()
        {
            foreach (var item in servicioContactoEmpresarial.GetAllDto())
            {
                gridViewCE.Rows.Add(item.Id, item.Nombre, item.Telefono, item.NombreEmpresa, item.Correo);
            }
        }

        public void LlenarGridView2()
        {
            gridViewCE2.DataSource = servicioContactoEmpresarial.GetAllDto();
        }

        public void LlenarGridView3()
        {
            BindingSource bin = new BindingSource();
            bin.DataSource = servicioContactoEmpresarial.GetAllDto();
            gridViewCE3.DataSource = bin;
        }
    }
}