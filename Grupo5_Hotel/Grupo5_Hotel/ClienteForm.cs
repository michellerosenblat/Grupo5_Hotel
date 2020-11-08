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
        public ClienteForm()
        {
            InitializeComponent();
            
            
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            clienteServicio = new ClienteServicio();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            dataClientes.DataSource = clienteServicio.TraerClientes();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaClienteForm altaForm = new AltaClienteForm();
            altaForm.Owner = this;
            altaForm.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dataClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataClientes.Columns["id"].Visible = false;
        }

        private void ClienteForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ListarClientes();
            }
        }
    }
}
