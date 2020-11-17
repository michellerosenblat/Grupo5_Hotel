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
        //HotelServicio hotelServicio;
        private Menu menu;
        public HotelForm()
        {
            InitializeComponent();
            menu = new Menu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataHotel.DataSource = HotelServicio.TraerHoteles();
            dataHotel.Show();
        }

        private void HotelesForm_Load(object sender, EventArgs e)
        {
            TransparentBackground(lblHoteles);
            dataHotel.Hide();
            //hotelServicio = new HotelServicio();
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
            menu.Show();
            this.Close();
        }
        private void TransparentBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }
    }
}
