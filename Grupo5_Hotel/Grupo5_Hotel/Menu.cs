using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo5_Hotel
{
    public partial class Menu : Form
    {
        private ClienteForm clienteForm;
        public Menu()
        {
            InitializeComponent();
            clienteForm = new ClienteForm();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            clienteForm.Owner = this;
            clienteForm.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
