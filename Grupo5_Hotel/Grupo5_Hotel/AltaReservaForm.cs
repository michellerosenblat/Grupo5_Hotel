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
    public partial class AltaReservaForm : Form
    {
        ReservaServicio reservaServicio;
        ClienteServicio clienteServicio;
        HabitacionServicio habitacionServicio;
        HotelServicio hotelServicio;
        ReservaForm reservaForm;
        public AltaReservaForm()
        {
            InitializeComponent();
            reservaServicio = new ReservaServicio();
            clienteServicio = new ClienteServicio();
            habitacionServicio = new HabitacionServicio();
            hotelServicio = new HotelServicio();
        }
        private void AltaReservaForm_Load(object sender, EventArgs e)
        {
            reservaForm = new ReservaForm();
            ListarClientes();
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            reservaForm.Show();
            this.Close();
        }
        private void btmLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Errores))
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                reservaServicio.InsertarReserva(CrearReserva());
                MessageBox.Show("Se ha ingresado correctamente la reserva");
                if (comboClientes.SelectedIndex.Equals(comboClientes))
                {
                    
                }
                BorrarCampos();
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string Errores
        {
            get
            {
                return (Validacion.ValidarNumero("IdCliente", comboClientes.SelectedIndex.ToString()) +
                        Validacion.ValidarNumero("IdHotel", cmbHotel.SelectedIndex.ToString()) +
                        Validacion.ValidarNumero("IdHabitación", cmbHabitacion.SelectedIndex.ToString()));
            }
        }

        private Reserva CrearReserva()
        {
            return new Reserva(reservaServicio.ProximoId(), ((Cliente)comboClientes.SelectedItem).Id, ((Habitacion)cmbHabitacion.SelectedItem).Id, int.Parse(lblCantindadHuespedes.Text), dtpIngreso.Value, dtpEgreso.Value);
        }

        private void BorrarCampos()
        {
            txtboxHuespedes.Clear();
            comboClientes.SelectedIndex = -1;
            

        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            comboClientes.DataSource = clienteServicio.TraerClientes();
        }
        private void ClienteForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ListarClientes();
            }
        }
        private void comboClientes_Click(object sender, EventArgs e)
        {           
        }
        private void cmbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHabitacion.Enabled = true;
        }
        private void cmbHotel_Click(object sender, EventArgs e)
        {
            cmbHotel.DataSource = hotelServicio.TraerHoteles();
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbHabitacion_Click(object sender, EventArgs e)
        {
            Hotel hotel = (Hotel)cmbHotel.SelectedItem;
            cmbHabitacion.DataSource = habitacionServicio.TraerHabitacionesPorId(hotel.id);
        }
    }
}
