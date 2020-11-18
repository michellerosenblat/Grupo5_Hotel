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
        List<Cliente> clientesConReserva;
        public ReporteReservasForm()
        {
            InitializeComponent();
            clientesConReserva = new List<Cliente>();
        }

        private void ReporteReservasForm_Load(object sender, EventArgs e)
        {
            LlenarCmbCliente();
            txtNroClientes.Text = listaclientesconreserva().Count.ToString();
            txtNroReservas.Text = ReservaServicio.TraerReservas().Count.ToString();
            dataReserva.Hide();
        }
        private List<Cliente> listaclientesconreserva()
        {
            if (clientesConReserva.Count() == 0) { 
            List<ReservaWrapper> reservas = ReservaServicio.TraerReservaWrapper();
                foreach  (ReservaWrapper r in reservas)
                {
                    if (!(r.Cliente is null))
                    {
                        clientesConReserva.Add(r.Cliente);
                    }
                    
                }
            }
            return clientesConReserva.Distinct().ToList();

        }
        private void LlenarCmbCliente()
        {
            cmbCliente.DataSource = listaclientesconreserva();
            cmbCliente.SelectedIndex = -1;
            dataReserva.DataSource = null;
        }
        private void ListarReservas()
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedValue;
            if (!(cliente is null))
            {
                dataReserva.DataSource = null;
                dataReserva.DataSource = ReservaServicio.TraerReservasPorIdCliente(cliente.Id);
                dataReserva.Columns["Cliente"].Visible = false;
                dataReserva.Columns["Reserva"].Visible = false;
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {          
            ListarReservas();
            if (cmbCliente.Text != null)
                dataReserva.Show();
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
