﻿namespace Grupo5_Hotel
{
    partial class AltaHabitacionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.Hotel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlazas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.Precio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCancelable = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelCancelable = new System.Windows.Forms.Panel();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.panelCancelable.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbHotel
            // 
            this.cmbHotel.BackColor = System.Drawing.Color.Moccasin;
            this.cmbHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(282, 109);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(200, 21);
            this.cmbHotel.TabIndex = 0;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            this.cmbHotel.Click += new System.EventHandler(this.cmbHotel_Click);
            // 
            // Hotel
            // 
            this.Hotel.AutoSize = true;
            this.Hotel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotel.ForeColor = System.Drawing.Color.Moccasin;
            this.Hotel.Location = new System.Drawing.Point(178, 112);
            this.Hotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hotel.Name = "Hotel";
            this.Hotel.Size = new System.Drawing.Size(48, 16);
            this.Hotel.TabIndex = 1;
            this.Hotel.Text = "Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(178, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cant. Plazas";
            // 
            // cmbPlazas
            // 
            this.cmbPlazas.BackColor = System.Drawing.Color.Moccasin;
            this.cmbPlazas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPlazas.FormattingEnabled = true;
            this.cmbPlazas.Location = new System.Drawing.Point(282, 151);
            this.cmbPlazas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPlazas.Name = "cmbPlazas";
            this.cmbPlazas.Size = new System.Drawing.Size(200, 21);
            this.cmbPlazas.TabIndex = 3;
            this.cmbPlazas.SelectedIndexChanged += new System.EventHandler(this.cmbPlazas_SelectedIndexChanged);
            this.cmbPlazas.Click += new System.EventHandler(this.cmbPlazas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(178, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.Moccasin;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(282, 190);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.Click += new System.EventHandler(this.cmbCategoria_Click);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.Color.Moccasin;
            this.Precio.Location = new System.Drawing.Point(178, 228);
            this.Precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(54, 16);
            this.Precio.TabIndex = 6;
            this.Precio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Moccasin;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(282, 227);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblCancelable
            // 
            this.lblCancelable.AutoSize = true;
            this.lblCancelable.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelable.ForeColor = System.Drawing.Color.Moccasin;
            this.lblCancelable.Location = new System.Drawing.Point(178, 286);
            this.lblCancelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancelable.Name = "lblCancelable";
            this.lblCancelable.Size = new System.Drawing.Size(87, 16);
            this.lblCancelable.TabIndex = 8;
            this.lblCancelable.Text = "Cancelable";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(11, 102);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 34);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Moccasin;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(29, 347);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 34);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "VOLVER";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panelCancelable
            // 
            this.panelCancelable.BackColor = System.Drawing.Color.Moccasin;
            this.panelCancelable.Controls.Add(this.rbSi);
            this.panelCancelable.Controls.Add(this.rbNo);
            this.panelCancelable.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCancelable.Location = new System.Drawing.Point(310, 270);
            this.panelCancelable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelCancelable.Name = "panelCancelable";
            this.panelCancelable.Size = new System.Drawing.Size(135, 39);
            this.panelCancelable.TabIndex = 14;
            this.panelCancelable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCancelable_Paint);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(14, 12);
            this.rbSi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(37, 20);
            this.rbSi.TabIndex = 0;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(81, 12);
            this.rbNo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(44, 20);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Moccasin;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(11, 149);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 41);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "LIMPIAR CAMPOS";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Moccasin;
            this.lblDatos.Location = new System.Drawing.Point(165, 38);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(332, 31);
            this.lblDatos.TabIndex = 23;
            this.lblDatos.Text = "Datos de la habitación:";
            // 
            // AltaHabitacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo5_Hotel.Properties.Resources.Marrón_Dorado;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panelCancelable);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCancelable);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPlazas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hotel);
            this.Controls.Add(this.cmbHotel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaHabitacionForm";
            this.Text = "AltaHabitacionForm";
            this.Load += new System.EventHandler(this.AltaHabitacionForm_Load);
            this.panelCancelable.ResumeLayout(false);
            this.panelCancelable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.Label Hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlazas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCancelable;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panelCancelable;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblDatos;
    }
}