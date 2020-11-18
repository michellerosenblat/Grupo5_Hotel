﻿using Grupo5_Hotel.Entidades.Entidades;
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
    public partial class AltaHabitacionForm : Form
    {

        //private HotelServicio hotelServicio;
        //private HabitacionServicio habitacionServicio;
        private int hotelSeleccionado;
        public AltaHabitacionForm(int hotelSeleccionado)
        {
            InitializeComponent();
            //hotelServicio = new HotelServicio();
            //habitacionServicio = new HabitacionServicio();
            this.hotelSeleccionado = hotelSeleccionado;
        }

        private void CargarPlazas()
        {
            cmbPlazas.Items.Add("1");
            cmbPlazas.Items.Add("2");
            cmbPlazas.Items.Add("3");
            cmbPlazas.Items.Add("4");
            cmbPlazas.Items.Add("5");
        }

        private void AltaHabitacionForm_Load(object sender, EventArgs e)
        {
            cmbHotel.DataSource = HotelServicio.TraerHoteles();
            //cmbHotel.SelectedItem = cmbHotel.Items.Equals(hotelSeleccionado);
            cmbHotel.SelectedIndex = hotelSeleccionado;
            CargarPlazas();
            CargarCategorias();
        }
        private void BorrarCampos()
        {
            cmbHotel.SelectedIndex = -1;
            cmbPlazas.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            rbSi.Checked = false;
            rbNo.Checked = false;
        }
        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHotel_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbPlazas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPlazas_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {
           
        }
        private void CargarCategorias()
        {
            cmbCategoria.Items.Add("Estandar");
            cmbCategoria.Items.Add("De lujo");
            cmbCategoria.Items.Add("Presidencial");
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rbSi.Checked && !rbNo.Checked && !string.IsNullOrEmpty(this.Errores))
                {
                    throw new FormatException("Error en los campos: " + "\n" + this.Errores + "Debe seleccionar si es cancelable o no");
                }
                if (!rbSi.Checked && !rbNo.Checked)
                {
                    lblCancelable.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.Errores))
                        throw new FormatException("Error en los campos: " + "\n" + this.Errores);
                    HabitacionServicio.InsertarHabitacion(CrearHabitacion());
                    MessageBox.Show("Se ha ingresado correctamente la habitacion");
                    lblCancelable.ForeColor = System.Drawing.Color.Black;
                    ((HabitacionForm)this.Owner).ChangeHotelTo(cmbHotel.SelectedIndex);
                    BorrarCampos();
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }
        private string Errores
        {
            get
            {
                return Validacion.ValidarComboBox(cmbHotel.SelectedIndex, "Hotel") +
                    Validacion.ValidarComboBox (cmbPlazas.SelectedIndex, "Cantidad de plazas")
                    + Validacion.ValidarComboBox (cmbCategoria.SelectedIndex, "Categoría") +
                    Validacion.ValidarNumero(txtPrecio.Text, "Precio");
            }
        }

        private void panelCancelable_Paint(object sender, PaintEventArgs e)
        {
            rbSi.Checked = false;
            rbNo.Checked = false;
        }
        private Habitacion CrearHabitacion()
        {
           return new Habitacion(((Hotel)cmbHotel.SelectedItem).Id, int.Parse(cmbPlazas.SelectedItem.ToString()), cmbCategoria.SelectedItem.ToString(), int.Parse(txtPrecio.Text), rbSi.Checked);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

    }
}
