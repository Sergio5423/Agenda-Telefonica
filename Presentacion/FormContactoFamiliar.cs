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

namespace Presentacion
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

        }

        public void Limpiar()
        {
            lbId.Text = string.Empty;
            lbNombre.Text = string.Empty;
            lbTelefono.Text = string.Empty;
        }

        public void Capturar()
        {
            var contacto = new ContactoFamiliar();

            contacto.Id = int.Parse(lbId.Text);
            contacto.Nombre = lbNombre.Text;
            contacto.Telefono = lbTelefono.Text;
            contacto.FechaNacimiento = dtpFecha.Value;
            var msg = servicioContactoFamiliar.Add(contacto);
            lbId.Focus();
            dtpFecha.Value = DateTime.Now;
        }

        public void CargarLista()
        {
            var lista = servicioContactoFamiliar.GetAll();
            foreach (var item in lista)
            {
                lstFamiliar.Items.Add(item.Nombre);
            }
        }
    }
}
