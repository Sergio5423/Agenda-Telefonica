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
    public partial class Menu : Form
    {
        FormContactoFamiliar formContactoFamiliar;
        FormContactoEmpresarial formContactoEmpresarial;
        
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            formContactoFamiliar = new FormContactoFamiliar();
            formContactoEmpresarial = new FormContactoEmpresarial();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmpresarial_Click(object sender, EventArgs e)
        {
            formContactoEmpresarial.ShowDialog();
        }

        private void btnFamiliar_Click(object sender, EventArgs e)
        {
            formContactoFamiliar.ShowDialog();
        }
    }
}
