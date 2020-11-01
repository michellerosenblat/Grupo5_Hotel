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
        public HotelesForm()
        {
            InitializeComponent();
            hotelServicio = new HotelServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataHoteles.DataSource = hotelServicio.TraerHoteles();
        }
    }
}
