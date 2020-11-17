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
    public partial class HabitacionForm : Form
    {
        //private HotelServicio hotelServicio;
        private HabitacionServicio habitacionServicio;
        private Menu menu;
        public HabitacionForm()
        {
            InitializeComponent();
            habitacionServicio = new HabitacionServicio();
            //hotelServicio = new HotelServicio();
            //cmbHotel.SelectedIndex = -1;
            menu = new Menu();
        }

        private void HabitacionForm_Load(object sender, EventArgs e)
        {
            LlenarComboHoteles();
            TransparentBackground(lblHotel);
            TransparentBackground(lblHabitaciones);
            dataClientes.Hide();

        }
        private void LlenarComboHoteles()
        {
            cmbHotel.DataSource = HotelServicio.TraerHoteles();
            cmbHotel.SelectedIndex = -1;
            dataClientes.DataSource = null;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaHabitacionForm altaHabitaciones = new AltaHabitacionForm(cmbHotel.SelectedIndex);
            altaHabitaciones.Owner = this;
            altaHabitaciones.Show();
            this.Hide();
        }

        private void cmbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarHabitacionPorHotel();
            dataClientes.Show();
        }

        private void ListarHabitacionPorHotel()
        {
            Hotel hotel = (Hotel)cmbHotel.SelectedValue;
            if (!(hotel is null))
            dataClientes.DataSource = habitacionServicio.TraerHabitacionesPorId(hotel.Id);
        }

        private void cmbHotel_Click(object sender, EventArgs e)
        {
            
        }

        private void HabitacionForm_VisibleChanged(object sender, EventArgs e)
        {
            ListarHabitacionPorHotel();
        }
        public void ChangeHotelTo(int hotel)
        {
            cmbHotel.SelectedIndex = hotel;
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
