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
    public partial class HabitacionForm : Form
    {
        private HotelServicio hotelServicio;
        public HabitacionForm()
        {
            InitializeComponent();
        }

        private void HabitacionForm_Load(object sender, EventArgs e)
        {
            hotelServicio = new HotelServicio();
            List <Hotel> hoteles = hotelServicio.TraerHoteles();
            LlenarComboHoteles(hoteles);
        }
        private void LlenarComboHoteles(List <Hotel> hoteles)
        {
            foreach (Hotel hotel in hoteles)
            {
                cmbHoteles.Items.Add(hotel.Nombre);
            }
        }
    }
}
