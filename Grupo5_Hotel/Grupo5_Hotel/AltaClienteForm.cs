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
    }
}

