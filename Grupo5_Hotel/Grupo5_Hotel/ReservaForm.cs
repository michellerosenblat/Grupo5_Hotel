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
        AltaReservaForm altaform;

        public ReservaForm()
        {
            InitializeComponent();
        }

        private void ReservaForm_Load(object sender, EventArgs e)
        {
            reservaServicio = new ReservaServicio();
            altaform = new AltaReservaForm();
        }

        private void btmAltaReserva_Click(object sender, EventArgs e)
        {
            List<Reserva> reservas = reservaServicio.TraerReservas();
            foreach (Reserva res in reservas)
            {
                listBox1.Items.Add(res);

            }
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btmAltaReserva_Click_1(object sender, EventArgs e)
        {
            altaform.Show();
            this.Close();
        }
    }
}
