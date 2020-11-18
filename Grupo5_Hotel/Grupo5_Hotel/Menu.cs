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
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm ();
            clienteForm.Owner = this;
            clienteForm.Show();
            this.Hide();
        }
        private void Menu_Load(object sender, EventArgs e)
        {


        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            HotelForm hotelForm = new HotelForm();
            hotelForm.Owner = this;
            hotelForm.Show();
            this.Hide();
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            HabitacionForm habitacionForm = new HabitacionForm();
            habitacionForm.Owner = this;
            habitacionForm.Show();
            this.Hide();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            ReservaForm reservaForm = new ReservaForm();
            reservaForm.Owner = this;
            reservaForm.Show();
            this.Hide();
        }

        private void btmReporteHabitaciones_Click(object sender, EventArgs e)
        {
            ReporteHabitacionesXHotelForm reportehabitacionform = new ReporteHabitacionesXHotelForm();
            reportehabitacionform.Owner = this;
            reportehabitacionform.Show();
            this.Hide();
        }
    }

}
