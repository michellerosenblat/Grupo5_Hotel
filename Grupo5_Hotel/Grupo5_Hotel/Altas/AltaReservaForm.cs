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
using Grupo5_Hotel.Entidades.Excepciones;

namespace Grupo5_Hotel
{
    public partial class AltaReservaForm : Form
    {
        public AltaReservaForm()
        {
            InitializeComponent();
        }
        private void AltaReservaForm_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarHoteles();
            cmbHabitacion.Hide();
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
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
                ReservaServicio.InsertarReserva(CrearReserva());
                MessageBox.Show("Se ha ingresado correctamente la reserva");
               /* if (comboClientes.SelectedIndex.Equals(comboClientes))
                {
                    
                }+*/
                BorrarCampos();
            }
            catch (CantHuespedesException cantEx)
            {
                MessageBox.Show(cantEx.Message);
            }
            catch (FechaIncorrectaException fechaEx)
            {
                MessageBox.Show(fechaEx.Message);
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
                return (Validacion.ValidarComboBox(comboClientes.SelectedIndex, "Cliente") +
                    Validacion.ValidarComboBox(cmbHotel.SelectedIndex, "Hotel") +
                    Validacion.ValidarComboBox(cmbHabitacion.SelectedIndex, "Habitación") +
                    Validacion.ValidarNumero(txtCantHuespedes.Text, "Cantidad de Huespedes"));
            }
        }
        private Reserva CrearReserva()
        { 
            return new Reserva(((Cliente) comboClientes.SelectedItem).Id, ((Habitacion)cmbHabitacion.SelectedItem).Id, int.Parse(txtCantHuespedes.Text), dtpIngreso.Value, dtpEgreso.Value);
        }

        private void BorrarCampos()
        {
            txtCantHuespedes.Clear();
            comboClientes.SelectedIndex = -1;
            cmbHotel.SelectedIndex = -1;
            cmbHabitacion.SelectedIndex = -1;
            cmbHabitacion.Enabled = false;
            dtpIngreso.Value = DateTime.Now;
            dtpEgreso.Value = DateTime.Now;

        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            comboClientes.DataSource = ClienteServicio.TraerClientes();
        }

        private void ListarHoteles()
        {
            cmbHotel.DataSource = HotelServicio.TraerHoteles();
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hotel hotel = (Hotel)cmbHotel.SelectedItem;
            if (!(hotel is null)) {
                cmbHabitacion.Enabled = true;
                cmbHabitacion.DataSource = HabitacionServicio.TraerHabitacionesPorId(hotel.Id);
                cmbHabitacion.Show();
            }
           
        }

        private void cmbHabitacion_Click(object sender, EventArgs e)
        {
           
        }

        private void AltaReservaForm_VisibleChanged(object sender, EventArgs e)
        {
            BorrarCampos();
        }


        private void cmbHotel_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

    }
}
