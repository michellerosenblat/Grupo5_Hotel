using Grupo5_Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo5_Hotel
{
    public partial class HotelForm : Form
    {
        HotelServicio hotelServicio;
        //private AltaHotelForm altaHotel;
        public HotelForm()
        {
            InitializeComponent();
            //altaHotel = new AltaHotelForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListHoteles.DataSource = hotelServicio.TraerHoteles();
        }

        private void HotelesForm_Load(object sender, EventArgs e)
        {
            hotelServicio = new HotelServicio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaHotelForm altaHotel = new AltaHotelForm();
            altaHotel.Owner = this;
            altaHotel.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
