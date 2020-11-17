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
            TransparentBackground(lblTitulo);
            TransparentBackground(lblWhiteHat);
            TransparentBackground(lblSeleccion);
            TransparentBackground(lbllinea); // más sencillo que los códigos que encontré para dibujar una simple línea


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

        private void btmReporteReserva_Click(object sender, EventArgs e)
        {
            ReporteReservasForm reporteReservaform = new ReporteReservasForm();
            reporteReservaform.Owner = this;
            reporteReservaform.Show();
            this.Hide();
        }

        private void btmReporteHabitaciones_Click(object sender, EventArgs e)
        {
            ReporteHabitacionesXHotelForm reportehabitacionform = new ReporteHabitacionesXHotelForm();
            reportehabitacionform.Owner = this;
            reportehabitacionform.Show();
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
