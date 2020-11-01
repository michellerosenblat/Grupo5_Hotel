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
        ClienteServicio clienteServicio;
        ClienteForm clienteForm;
        public AltaClienteForm()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje="";
            List <string> errores = ValidarDatos();
            if (errores.Any()) {
                foreach (string error in errores)
                {
                    mensaje += error + "\n";
                }
                MessageBox.Show(mensaje);
            }
            else {
                clienteServicio.InsertarCliente(CrearCliente());
                MessageBox.Show("Se ha ingresado correctamente el cliente");
                BorrarCampos();
            }
        }
        private List <string> ValidarDatos()
        {
            List<string> errores = new List<string>();
            errores.Add(Validacion.ValidarString(txtNombre.Text, "Nombre"));
            errores.Add (Validacion.ValidarString(txtApellido.Text, "Apellido"));
            errores.Add (Validacion.ValidarString(txtDireccion.Text, "Dirección"));
            errores.Add (Validacion.ValidarNumero(txtTelefono.Text, "Teléfono"));
            errores.Add (Validacion.ValidarString(txtMail.Text, "Mail"));
            return errores;
        }
        private Cliente CrearCliente()
        {
            return new Cliente(clienteServicio.ProximoId(),txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
        }

        private void AltaClienteForm_Load(object sender, EventArgs e)
        {
            clienteForm = new ClienteForm();
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
            clienteForm.Show();
            this.Close();
        }
    }
}
