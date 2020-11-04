using Grupo5_Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo5_Hotel
{
    public partial class ClienteForm : Form
    {
        ClienteServicio clienteServicio;
        AltaClienteForm altaForm;
        public ClienteForm()
        {
            InitializeComponent();
            
            
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            clienteServicio = new ClienteServicio();
            altaForm = new AltaClienteForm();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataClientes.DataSource = clienteServicio.TraerClientes();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            altaForm.Owner = this;
            altaForm.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
