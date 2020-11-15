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
        //ReservaServicio reservaServicio;
        //ClienteServicio clienteServicio;
        HabitacionServicio habitacionServicio;
        AltaReservaForm altaform;
        public ReservaForm()
        {
            InitializeComponent();
            
        }

        private void ReservaForm_Load(object sender, EventArgs e)
        {
            //reservaServicio = new ReservaServicio();
            //clienteServicio = new ClienteServicio();
            habitacionServicio = new HabitacionServicio();
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            this.dataReserva.DataSource = null; // esto es opcional, podes limpiar la grilla antes de ocultar.
            this.Owner.Show();
            this.Hide();
        }

        private void btmAltaReserva_Click_1(object sender, EventArgs e)
        {
            AltaReservaForm altaform = new AltaReservaForm();
            altaform.Owner = this;
            altaform.Show();
            this.Hide();
        }

         private void btnListarReserva_Click(object sender, EventArgs e)
        {
            dataReserva.DataSource = ReservaServicio.TraerReservaWrapper();
            //dataReserva.Columns["idCliente"].Visible = false;
            dataReserva.Columns["Reserva"].Visible = false;
        }

  
    }
}
