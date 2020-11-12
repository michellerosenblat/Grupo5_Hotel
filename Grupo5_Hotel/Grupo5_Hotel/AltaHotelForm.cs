using Grupo5_Hotel.Entidades.Entidades;
using Grupo5_Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo5_Hotel
{
    public partial class AltaHotelForm : Form
    {
        HotelServicio hotelServicio;
        HotelForm hotelForm;
        public AltaHotelForm()
        {
            InitializeComponent();
            hotelServicio = new HotelServicio();
            comboEstrellas.Items.Add("1");
            comboEstrellas.Items.Add("2");
            comboEstrellas.Items.Add("3");
            comboEstrellas.Items.Add("4");
            comboEstrellas.Items.Add("5");
        }
        private string Errores
        {
            get
            {
                return (Validacion.ValidarString(textNombre.Text, "Nombre") +
                        Validacion.ValidarString(textDireccion.Text, "Dirección") +
                        Validacion.ValidarNumero(comboEstrellas.Text, "Estrellas"));       
            }
        }
        private Hotel CrearHotel()
        {
            //return new Hotel(hotelServicio.ProximoId(), textNombre.Text, textDireccion.Text, comboEstrellas.SelectedIndex , checkBox1.Checked);
            return new Hotel(hotelServicio.ProximoId(), textNombre.Text, textDireccion.Text, comboEstrellas.SelectedIndex, rbSi.Checked);
           
        }


        private void AltaHotelForm_Load(object sender, EventArgs e)
        {
            hotelForm = new HotelForm();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rbSi.Checked && !rbNo.Checked && !string.IsNullOrEmpty(this.Errores))
                {
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores + "Debe seleccionar si posee o no Amenities");
                }
                    if (!rbSi.Checked && !rbNo.Checked)
                {
                    lblAmenities.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.Errores))
                        throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                    hotelServicio.InsertarHotel(CrearHotel());
                    MessageBox.Show("Se ha ingresado correctamente el hotel");
                    lblAmenities.ForeColor = System.Drawing.Color.Black;
                    BorrarCampos();
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }

        private void BorrarCampos()
        {
            textNombre.Clear();
            textDireccion.Clear();
            comboEstrellas.SelectedIndex = -1;
            rbSi.Checked = false;
            rbNo.Checked = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            hotelForm.Show();
            this.Close();
        }

        private void panelAmenities_Paint(object sender, PaintEventArgs e)
        {
            rbSi.Checked = false;
            rbNo.Checked = false;
        }

        private void comboEstrellas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
