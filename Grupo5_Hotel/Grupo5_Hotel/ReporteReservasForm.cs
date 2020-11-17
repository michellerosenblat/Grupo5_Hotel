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
    public partial class ReporteReservasForm : Form
    { 

        //ReservaServicio reservaServicio;
        //ClienteServicio clienteServicio;
        //Menu menuForm;
        public ReporteReservasForm()
        {
            InitializeComponent();
            //reservaServicio = new ReservaServicio();
            //clienteServicio = new ClienteServicio();
            //menuForm = new Menu();
        }

        private void ReporteReservasForm_Load(object sender, EventArgs e)
        {
            LlenarCmbCliente();
            txtNroClientes.Text = listaclientesconreserva().Count.ToString();
            txtNroReservas.Text = ReservaServicio.TraerReservas().Count.ToString();

            TransparentBackground(lblReporte);
            TransparentBackground(lblNroReservas);
            TransparentBackground(lblTotalClientes);
            TransparentBackground(lblTotalReservas);
            TransparentBackground(lbllinea);
            dataReserva.Hide();
        }
        private List<Cliente> listaclientesconreserva()
        {
            List<Cliente> listadoclientes = new List<Cliente>();
            List<Reserva> listadoreserva = ReservaServicio.TraerReservas();
            List<Cliente> clientes = ClienteServicio.TraerClientes();
            foreach (Cliente c in clientes)
            {
                foreach (Reserva res in listadoreserva)
                {
                    if (c.Id == res.IdCliente)
                        listadoclientes.Add(c);
                }
            }
            return listadoclientes;
        }
        private void LlenarCmbCliente()
        {
            cmbCliente.DataSource = listaclientesconreserva();
            cmbCliente.SelectedIndex = -1;
            dataReserva.DataSource = null;
        }
        private void ListarReservas()
        {
            Cliente Cliente = (Cliente)cmbCliente.SelectedValue;
            if (!(Cliente is null))
            {
                dataReserva.DataSource = ReservaServicio.TraerReservasPorIdCliente(Cliente.Id);
                dataReserva.Columns["Cliente"].Visible = false;
                dataReserva.Columns["Reserva"].Visible = false;
            }
            else { }

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarReservas();
            dataReserva.Show();
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
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
