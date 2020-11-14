using Grupo5_Hotel.Negocio;
using Grupo5_Hotel.Entidades;
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
using Grupo5_Hotel.Entidades.Entidades;

namespace Grupo5_Hotel
{
    public partial class ReservaForm : Form
    {
        ReservaServicio reservaServicio;
        ClienteServicio clienteServicio;
        HabitacionServicio habitacionServicio;
        AltaReservaForm altaform;
        Menu menu;

        public ReservaForm()
        {
            InitializeComponent();
            
        }

        private void ReservaForm_Load(object sender, EventArgs e)
        {
            reservaServicio = new ReservaServicio();
            clienteServicio = new ClienteServicio();
            habitacionServicio = new HabitacionServicio();
            altaform = new AltaReservaForm();
            menu = new Menu();

        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void btmAltaReserva_Click_1(object sender, EventArgs e)
        {
            altaform.Owner = this;
            altaform.Show();
            this.Hide();
        }

         private void btnListarReserva_Click(object sender, EventArgs e)
        {
            dataReserva.DataSource = reservaServicio.TraerReservaWrapper();
            //dataReserva.Columns["idCliente"].Visible = false;
            dataReserva.Columns["Reserva"].Visible = false;
        }

  
    }
}
