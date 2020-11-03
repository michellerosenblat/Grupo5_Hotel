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
    public partial class HotelesForm : Form
    {
        HotelServicio hotelServicio;
        AltaHotelForm altaHotel;
        public HotelesForm()
        {
            InitializeComponent();
            altaHotel = new AltaHotelForm();

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
            altaHotel.Owner = this;
            altaHotel.Show();
            this.Hide();
        }
    }
}
