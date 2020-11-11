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
    public partial class AltaHabitacionForm : Form
    {
        //seria mejor pasarselo por parametro del form anterior? o es necesario todas las veces 
        // crear un servicio nuevo?
        private HotelServicio hotelServicio;
        private HabitacionServicio habitacionServicio;
        public AltaHabitacionForm()
        {
            InitializeComponent();
            hotelServicio = new HotelServicio();
            habitacionServicio = new HabitacionServicio();
        }

        private void CargarPlazas()
        {
            cmbPlazas.Items.Add("1");
            cmbPlazas.Items.Add("2");
            cmbPlazas.Items.Add("3");
            cmbPlazas.Items.Add("4");
            cmbPlazas.Items.Add("5");
        }

        private void AltaHabitacionForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHotel_Click(object sender, EventArgs e)
        {
            cmbHotel.DataSource = hotelServicio.TraerHoteles();
        }

        private void cmbPlazas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPlazas_Click(object sender, EventArgs e)
        {
            CargarPlazas();
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            cmbCategoria.Items.Add("Estandar");
            cmbCategoria.Items.Add("De lujo");
            cmbCategoria.Items.Add("Presidencial");
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rbSi.Checked && !rbNo.Checked && !string.IsNullOrEmpty(this.Errores))
                {
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores + "Debe seleccionar si es cancelable o no");
                }
                if (!rbSi.Checked && !rbNo.Checked)
                {
                    lblCancelable.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.Errores))
                        throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                    habitacionServicio.InsertarHabitacion(CrearHabitacion());
                    MessageBox.Show("Se ha ingresado correctamente la habitacion");
                    lblCancelable.ForeColor = System.Drawing.Color.Black;
                    //BorrarCampos();
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }
        private string Errores
        {
            get
            {
                return Validacion.ValidarComboBox(cmbHotel.SelectedIndex, "hotel") +
                    Validacion.ValidarComboBox (cmbPlazas.SelectedIndex, "cantidad de plazas")
                    + Validacion.ValidarComboBox (cmbCategoria.SelectedIndex, "categoría") +
                    Validacion.ValidarNumero(txtPrecio.Text, "precio");
            }
        }

        private void panelCancelable_Paint(object sender, PaintEventArgs e)
        {
            rbSi.Checked = false;
            rbNo.Checked = false;
        }
        private Habitacion CrearHabitacion()
        {
           return new Habitacion(((Hotel)cmbHotel.SelectedItem).id, int.Parse(cmbPlazas.SelectedItem.ToString()), cmbCategoria.SelectedItem.ToString(), int.Parse(txtPrecio.Text), rbSi.Checked);
        }
    }
}
