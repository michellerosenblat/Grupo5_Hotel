using Grupo5_Hotel.Negocio;
using Grupo5_Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grupo5_Hotel.Entidades.Entidades;

namespace Grupo5_Hotel
{
    public partial class ReporteHabitacionesXHotelForm : Form
    {
        HabitacionServicio habitacionservicio;
        HotelServicio hotelservicio;
        ReservaServicio reservaservicio;
        Menu menuForm;

        public ReporteHabitacionesXHotelForm()
        {
            InitializeComponent();
            habitacionservicio = new HabitacionServicio();
            hotelservicio = new HotelServicio();
            reservaservicio = new ReservaServicio();
            menuForm = new Menu();
        }

        private void ReporteHabitacionesXHotelForm_Load(object sender, EventArgs e)
        {
            LlenarCmbHotel();
            LlenarResumenGerencial();
            lblQFacTot.Hide();
            lblQOcupProm.Hide();
            lblQFacProm.Hide();
        }
        private void LlenarCmbHotel()
        {
            cmbHotel.DataSource = hotelservicio.TraerHoteles();
            cmbHotel.SelectedIndex = -1;
        }
        private void LlenarResumenGerencial()
        {
            List<Reserva> listadoReservas = new List<Reserva>();
            listadoReservas = reservaservicio.TraerReservas();

            //foreach (Hotel hotel in hotelservicio.TraerHoteles())
            //{
            //    listadohabitaciones.AddRange(habitacionservicio.TraerHabitacionesPorId(hotel.Id));
            //}

            txtboxFacturacionTotal.Text = FacturacionTotal(listadoReservas).ToString();
            txtboxOcupacionPromedio.Text = ("% " + (OcupacionPromedio(listadoReservas)*100).ToString());
            txtboxFacturacionPromedio.Text = FacturacionPromedio(double.Parse(txtboxFacturacionTotal.Text), listadoReservas).ToString();
        }

        private Double FacturacionTotal(List<Reserva> reservas)
        {
              Double facturacion = 0;

             foreach (Reserva reserva in reservas)
             {
                if (reserva.Habitacion != null) //Necesario por si hay reservas mal cargadas en pruebas pasadas
                    if (reserva.FechaEgreso > reserva.FechaIngreso) //Necesario por si hay reservas mal cargadas en pruebas pasadas
                        facturacion += reserva.Habitacion.Precio * (reserva.FechaEgreso - reserva.FechaIngreso).TotalDays;

             }
                return facturacion;
        }

        private double OcupacionPromedio(List<Reserva> reservas)
        {
            int reservasTotal = 0;
            double ocupacionesPromedio = 0;
            double ocupacionesPromedioTotal;

            foreach (Reserva reserva in reservas)
            {
                if (reserva.Habitacion != null) //Necesario por si hay de reservas mal cargadas en pruebas pasadas
                {
                    reservasTotal += 1;
                    ocupacionesPromedio += (reserva.CantidadHuespedes) / (reserva.Habitacion.CantidadPlazas);
                }
            }
            return ocupacionesPromedioTotal = ocupacionesPromedio / reservasTotal;
        }
        private double FacturacionPromedio (double facturacion, List<Reserva> reservas)
        {
            double facturacionPromedio = 0;
            if (reservas.Count() != 0)
                facturacionPromedio = facturacion / reservas.Count();

            return facturacionPromedio;
        }

        private void LlenarResumenHotel (Hotel hotel)
        {
            List<Reserva> listadoReservasHotel = new List<Reserva>();
            listadoReservasHotel = reservaservicio.TraerReservasPorHotel(hotel);
            txtboxFacturacionTotalHotel.Text = FacturacionTotal(listadoReservasHotel).ToString();
            txtboxOcupacionPromedioHotel.Text = ("% " + (OcupacionPromedio(listadoReservasHotel) * 100).ToString());
            txtboxFacturacionPromedioHotel.Text = FacturacionPromedio(double.Parse(txtboxFacturacionTotalHotel.Text), listadoReservasHotel).ToString();

        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {   
            Hotel hotel = (Hotel)cmbHotel.SelectedValue;
            if (hotel != null)
                LlenarResumenHotel(hotel);
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Close();
        }

        private void btmQFacTot_MouseHover(object sender, EventArgs e)
        {
            lblQFacTot.Show();
        }
        private void btmQFacTot_MouseLeave(object sender, EventArgs e)
        {
            lblQFacTot.Hide();
        }

        private void btmQOcProm_MouseHover(object sender, EventArgs e)
        {
            lblQOcupProm.Show();
        }
        private void btmQOcProm_MouseLeave(object sender, EventArgs e)
        {
            lblQOcupProm.Hide();
        }
        private void btmQFacProm_MouseHover(object sender, EventArgs e)
        {
            lblQFacProm.Show();
        }

        private void btmQFacProm_MouseLeave(object sender, EventArgs e)
        {
            lblQFacProm.Hide();
        }
    }
}
