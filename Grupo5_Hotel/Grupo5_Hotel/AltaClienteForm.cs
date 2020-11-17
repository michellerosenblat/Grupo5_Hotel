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
    public partial class AltaClienteForm : Form
    {
        public AltaClienteForm()
        {
            InitializeComponent();
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {
                if (!string.IsNullOrEmpty(this.Errores))
                    throw new FormatException("Error en los campos: " + "\n"+this.Errores);
                ClienteServicio.InsertarCliente(CrearCliente());
                MessageBox.Show("Se ha ingresado correctamente el cliente");
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
        
        private string Errores
        {
            get
            {
                return (Validacion.ValidarString(txtNombre.Text, "Nombre") +
                        Validacion.ValidarString(txtApellido.Text, "Apellido") +
                        Validacion.ValidarString(txtDireccion.Text, "Dirección") +
                        Validacion.ValidarNumero(txtTelefono.Text, "Teléfono") +
                        Validacion.ValidarString(txtMail.Text, "Mail"));
            }
        }
        private Cliente CrearCliente()
        {
            return new Cliente(ClienteServicio.ProximoId(),txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
        }

        private void AltaClienteForm_Load(object sender, EventArgs e)
        {
            TransparentBackground(lblApellido);
            TransparentBackground(lblDatos);
            TransparentBackground(lblNombre);
            TransparentBackground(label2);
            TransparentBackground(label1);
            TransparentBackground(label3);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void BorrarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
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

