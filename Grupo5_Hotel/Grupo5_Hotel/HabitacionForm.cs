using Grupo5_Hotel.Entidades.Entidades;
using Grupo5_Hotel.Negocio;
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
    public partial class HabitacionForm : Form
    {
        private HotelServicio hotelServicio;
        private HabitacionServicio habitacionServicio;
        public HabitacionForm()
        {
            InitializeComponent();
            habitacionServicio = new HabitacionServicio();
            hotelServicio = new HotelServicio();
        }

        private void HabitacionForm_Load(object sender, EventArgs e)
        {
            LlenarComboHoteles();
        }
        private void LlenarComboHoteles()
        {
            cmbHotel.DataSource = hotelServicio.TraerHoteles();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaHabitacionForm altaHabitaciones = new AltaHabitacionForm(cmbHotel.SelectedIndex);
            altaHabitaciones.Owner = this;
            altaHabitaciones.Show();
            this.Hide();
        }

        private void cmbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarHabitacionPorHotel();
        }

        private void ListarHabitacionPorHotel()
        {
            Hotel hotel = (Hotel)cmbHotel.SelectedValue;
            if (!(hotel is null))
            dataClientes.DataSource = habitacionServicio.TraerHabitacionesPorId(hotel.id);
        }

        private void cmbHotel_Click(object sender, EventArgs e)
        {
            
        }

        private void HabitacionForm_VisibleChanged(object sender, EventArgs e)
        {
            ListarHabitacionPorHotel();
        }
        public void ChangeHotelTo(int hotel)
        {
            cmbHotel.SelectedIndex = hotel;
        }
    }
}
