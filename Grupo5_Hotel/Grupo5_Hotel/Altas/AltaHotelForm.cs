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
        HotelForm hotelForm;
        public AltaHotelForm()
        {
            InitializeComponent();
            comboEstrellas.Items.Add("1");
            comboEstrellas.Items.Add("2");
            comboEstrellas.Items.Add("3");
            comboEstrellas.Items.Add("4");
            comboEstrellas.Items.Add("5");
            this.comboEstrellas.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void AltaHotelForm_Load(object sender, EventArgs e)
        {
            hotelForm = new HotelForm();

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
            return new Hotel(HotelServicio.ProximoId(), textNombre.Text, textDireccion.Text, comboEstrellas.SelectedIndex, rbSi.Checked);

        }
        private void BorrarCampos()
        {
            textNombre.Clear();
            textDireccion.Clear();
            comboEstrellas.SelectedIndex = -1;
            rbSi.Checked = false;
            rbNo.Checked = false;
            lblAmenities.ForeColor = System.Drawing.Color.White;
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
                    HotelServicio.InsertarHotel(CrearHotel());
                    MessageBox.Show("Se ha ingresado correctamente el hotel");
                   
                    BorrarCampos();
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            hotelForm.Show();
            this.Close();
        }

    }
}
