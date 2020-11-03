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

        private List<string> ValidarDatos()
        {
            List<string> errores = new List<string>();
            errores.Add(Validacion.ValidarString(textNombre.Text, "Nombre"));
            errores.Add(Validacion.ValidarString(textDireccion.Text, "Dirección"));
            errores.Add(Validacion.ValidarNumero(comboEstrellas.Text, "Estrellas"));
            return errores;
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
            string mensaje = "";
            List<string> errores = ValidarDatos();
            if (errores.Any())
            {
                foreach (string error in errores)
                {
                    mensaje += error + "\n";
                }
                MessageBox.Show(mensaje);
            }
            else if (mensaje == "")
            {
                hotelServicio.InsertarHotel(CrearHotel());
                MessageBox.Show("Se ha ingresado correctamente el cliente");
            }
        }

        private void BorrarCampos()
        {
            textNombre.Clear();
            textDireccion.Clear();
            comboEstrellas.SelectedIndex = -1;
            checkBox1.Checked = false;
        }
    }
}
