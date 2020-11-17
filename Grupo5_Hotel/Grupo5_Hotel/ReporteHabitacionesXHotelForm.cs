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

        //HotelServicio hotelservicio;
        //ReservaServicio reservaservicio;
        private Menu menuForm;

        public ReporteHabitacionesXHotelForm()
        {
            InitializeComponent();
            //habitacionservicio = new HabitacionServicio();
            //hotelservicio = new HotelServicio();
            //reservaservicio = new ReservaServicio();
            //menuForm = new Menu();
        }

        private void ReporteHabitacionesXHotelForm_Load(object sender, EventArgs e)
        {

            LlenarResumenGerencial();
            LlenarCmbHotel();
            lblQFacTot.Hide();
            lblQOcupProm.Hide();
            lblQFacProm.Hide();


            lblHotel.Hide();
            cmbHotel.Hide();
            txtboxFacturacionTotal.Hide();
            txtboxFacturacionPromedio.Hide();
            txtboxOcupacionPromedio.Hide();
            txtboxFacturacionPromedioHotel.Hide();
            txtboxFacturacionTotalHotel.Hide();
            txtboxOcupacionPromedioHotel.Hide();

            TransparentBackground(lblHotel);
            TransparentBackground(lblReporte);
            TransparentBackground(lblFacturacionTotal);
            TransparentBackground(lblFacturacionPromedio);
            TransparentBackground(lblOcupacionPromedio);
        }
        private void LlenarCmbHotel()
        {
            cmbHotel.DataSource = HotelServicio.TraerHoteles();
            cmbHotel.SelectedIndex = -1;
        }
        private void LlenarResumenGerencial()
        {
            //List<Reserva> listadoReservas = new List<Reserva>();
            //listadoReservas = reservaservicio.TraerReservas();

            List<ReservaWrapper> listadoReservas = new List<ReservaWrapper>();
            listadoReservas = ReservaServicio.TraerReservaWrapper();

            //foreach (Hotel hotel in hotelservicio.TraerHoteles())
            //{
            //    listadohabitaciones.AddRange(habitacionservicio.TraerHabitacionesPorId(hotel.Id));
            //}

            txtboxFacturacionTotal.Text = FacturacionTotal(listadoReservas).ToString();
            txtboxOcupacionPromedio.Text = ((OcupacionPromedio(listadoReservas)*100).ToString() + " %");
            txtboxFacturacionPromedio.Text = FacturacionPromedio(double.Parse(txtboxFacturacionTotal.Text), listadoReservas).ToString();
        }

        private Double FacturacionTotal(List<ReservaWrapper> reservas)
        {
              Double facturacion = 0;

             foreach (ReservaWrapper reservaW in reservas)
             {
                if (reservaW.Habitacion != null) //Necesario por si hay reservas mal cargadas en pruebas pasadas
                    if (reservaW.Reserva.FechaEgreso > reservaW.Reserva.FechaIngreso) //Necesario por si hay reservas mal cargadas en pruebas pasadas
                        facturacion += reservaW.Habitacion.Precio * (reservaW.Reserva.FechaEgreso - reservaW.Reserva.FechaIngreso).TotalDays;

             }
                return facturacion;
        }

        private double OcupacionPromedio(List<ReservaWrapper> reservas)
        {
            int reservasTotal = 0;
            double ocupacionesPromedio = 0;
            double ocupacionesPromedioTotal;

            foreach (ReservaWrapper reservaW in reservas)
            {
                if (reservaW.Habitacion != null) //Necesario por si hay de reservas mal cargadas en pruebas pasadas
                {
                    reservasTotal += 1;
                    ocupacionesPromedio += (reservaW.Reserva.CantidadHuespedes) / (reservaW.Habitacion.CantidadPlazas);
                }
            }
            return ocupacionesPromedioTotal = ocupacionesPromedio / reservasTotal;
        }
        private double FacturacionPromedio (double facturacion, List<ReservaWrapper> reservas)
        {
            double facturacionPromedio = 0;
            if (reservas.Count() != 0)
                facturacionPromedio = facturacion / reservas.Count();

            return facturacionPromedio;
        }

        private void LlenarResumenHotel (Hotel hotel)
        {
            List<ReservaWrapper> listadoReservasHotel = new List<ReservaWrapper>();
            listadoReservasHotel = ReservaServicio.TraerReservasPorHotel(hotel);
            txtboxFacturacionTotalHotel.Text = FacturacionTotal(listadoReservasHotel).ToString();
            txtboxOcupacionPromedioHotel.Text = ((OcupacionPromedio(listadoReservasHotel) * 100).ToString() + " %");
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
            this.Owner.Show();
            this.Hide();
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

        private void btmGeneral_Click(object sender, EventArgs e)
        {           
            lblReporte.Text = "Reporte gerencial:";
            txtboxFacturacionPromedio.Show();
            txtboxFacturacionTotal.Show();
            txtboxOcupacionPromedio.Show();

            txtboxFacturacionPromedioHotel.Hide();
            txtboxFacturacionTotalHotel.Hide();
            txtboxOcupacionPromedioHotel.Hide();
            lblHotel.Hide();
            cmbHotel.Hide();
        }

        private void btmXHotel_Click(object sender, EventArgs e)
        {

            lblReporte.Text = "Reporte por hotel:";
            txtboxFacturacionPromedio.Hide();
            txtboxFacturacionTotal.Hide();
            txtboxOcupacionPromedio.Hide();

            txtboxFacturacionPromedioHotel.Show();
            txtboxFacturacionTotalHotel.Show();
            txtboxOcupacionPromedioHotel.Show();
            lblHotel.Show();
            cmbHotel.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btmRepRes_Click(object sender, EventArgs e)
        {
            ReporteReservasForm reportereservaform = new ReporteReservasForm();
            reportereservaform.Owner = this;
            reportereservaform.Show();
            this.Hide();
        }
        private void TransparentBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }
    }
}
