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
    public partial class AltaHotelForm : Form
    {
        HotelServicio hotelServicio;
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
            return new Hotel(hotelServicio.ProximoId(), textNombre.Text, textDireccion.Text, comboEstrellas.SelectedIndex , checkBox1.Checked);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void AltaHotelForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Errores))
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                hotelServicio.InsertarHotel(CrearHotel());
                MessageBox.Show("Se ha ingresado correctamente el hotel");
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

        private void BorrarCampos()
        {
            textNombre.Clear();
            textDireccion.Clear();
            comboEstrellas.SelectedIndex = -1;
            checkBox1.Checked = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
