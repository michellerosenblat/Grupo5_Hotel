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
    public partial class ClienteForm : Form
    {
        //ClienteServicio clienteServicio;
        public ClienteForm()
        {
            InitializeComponent();                        
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            TransparentBackground(lblCliente);
            dataClientes.Hide();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarClientes();
            dataClientes.Show();
        }

        private void ListarClientes()
        {
            dataClientes.DataSource = ClienteServicio.TraerClientes();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaClienteForm altaForm = new AltaClienteForm();
            altaForm.Owner = this;
            altaForm.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

       private void dataClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataClientes.Columns["id"].Visible = true;
        }

        private void ClienteForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ListarClientes();
            }
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
