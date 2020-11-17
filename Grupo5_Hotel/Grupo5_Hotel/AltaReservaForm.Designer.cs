namespace Grupo5_Hotel
{
    partial class AltaReservaForm
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
            this.btmAtras = new System.Windows.Forms.Button();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.btmLimpiar = new System.Windows.Forms.Button();
            this.txtCantHuespedes = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblCantindadHuespedes = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpEgreso = new System.Windows.Forms.DateTimePicker();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmAtras
            // 
            this.btmAtras.BackColor = System.Drawing.Color.Moccasin;
            this.btmAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAtras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtras.Location = new System.Drawing.Point(29, 347);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(90, 34);
            this.btmAtras.TabIndex = 0;
            this.btmAtras.Text = "VOLVER";
            this.btmAtras.UseVisualStyleBackColor = false;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // btmAgregar
            // 
            this.btmAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.btmAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAgregar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAgregar.Location = new System.Drawing.Point(11, 102);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(118, 34);
            this.btmAgregar.TabIndex = 1;
            this.btmAgregar.Text = "AGREGAR";
            this.btmAgregar.UseVisualStyleBackColor = false;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.BackColor = System.Drawing.Color.Moccasin;
            this.btmLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmLimpiar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLimpiar.Location = new System.Drawing.Point(11, 149);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(118, 41);
            this.btmLimpiar.TabIndex = 2;
            this.btmLimpiar.Text = "LIMPIAR CAMPOS";
            this.btmLimpiar.UseVisualStyleBackColor = false;
            this.btmLimpiar.Click += new System.EventHandler(this.btmLimpiar_Click);
            // 
            // txtCantHuespedes
            // 
            this.txtCantHuespedes.BackColor = System.Drawing.Color.Moccasin;
            this.txtCantHuespedes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantHuespedes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantHuespedes.Location = new System.Drawing.Point(282, 225);
            this.txtCantHuespedes.Name = "txtCantHuespedes";
            this.txtCantHuespedes.Size = new System.Drawing.Size(200, 22);
            this.txtCantHuespedes.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Moccasin;
            this.lblCliente.Location = new System.Drawing.Point(178, 112);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 16);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.ForeColor = System.Drawing.Color.Moccasin;
            this.lblHabitacion.Location = new System.Drawing.Point(178, 191);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(88, 16);
            this.lblHabitacion.TabIndex = 10;
            this.lblHabitacion.Text = "Habitación";
            // 
            // lblCantindadHuespedes
            // 
            this.lblCantindadHuespedes.AutoSize = true;
            this.lblCantindadHuespedes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantindadHuespedes.ForeColor = System.Drawing.Color.Moccasin;
            this.lblCantindadHuespedes.Location = new System.Drawing.Point(178, 228);
            this.lblCantindadHuespedes.Name = "lblCantindadHuespedes";
            this.lblCantindadHuespedes.Size = new System.Drawing.Size(86, 16);
            this.lblCantindadHuespedes.TabIndex = 11;
            this.lblCantindadHuespedes.Text = "Huespedes";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.Moccasin;
            this.lblIngreso.Location = new System.Drawing.Point(178, 292);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(64, 16);
            this.lblIngreso.TabIndex = 12;
            this.lblIngreso.Text = "Ingreso";
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgreso.ForeColor = System.Drawing.Color.Moccasin;
            this.lblEgreso.Location = new System.Drawing.Point(178, 320);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(57, 16);
            this.lblEgreso.TabIndex = 13;
            this.lblEgreso.Text = "Egreso";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dtpIngreso.CalendarTitleBackColor = System.Drawing.Color.Moccasin;
            this.dtpIngreso.CalendarTrailingForeColor = System.Drawing.Color.Moccasin;
            this.dtpIngreso.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Location = new System.Drawing.Point(282, 287);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(252, 22);
            this.dtpIngreso.TabIndex = 16;
            // 
            // dtpEgreso
            // 
            this.dtpEgreso.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEgreso.Location = new System.Drawing.Point(282, 315);
            this.dtpEgreso.Name = "dtpEgreso";
            this.dtpEgreso.Size = new System.Drawing.Size(252, 22);
            this.dtpEgreso.TabIndex = 17;
            // 
            // comboClientes
            // 
            this.comboClientes.BackColor = System.Drawing.Color.Moccasin;
            this.comboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboClientes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(282, 109);
            this.comboClientes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(200, 24);
            this.comboClientes.TabIndex = 18;
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.BackColor = System.Drawing.Color.Moccasin;
            this.cmbHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHabitacion.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(282, 188);
            this.cmbHabitacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(200, 24);
            this.cmbHabitacion.TabIndex = 19;
            this.cmbHabitacion.Click += new System.EventHandler(this.cmbHabitacion_Click);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.ForeColor = System.Drawing.Color.Moccasin;
            this.lblHotel.Location = new System.Drawing.Point(178, 152);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(48, 16);
            this.lblHotel.TabIndex = 20;
            this.lblHotel.Text = "Hotel";
            // 
            // cmbHotel
            // 
            this.cmbHotel.BackColor = System.Drawing.Color.Moccasin;
            this.cmbHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHotel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(282, 149);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(200, 24);
            this.cmbHotel.TabIndex = 21;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            this.cmbHotel.DisplayMemberChanged += new System.EventHandler(this.cmbHotel_DisplayMemberChanged);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Moccasin;
            this.lblDatos.Location = new System.Drawing.Point(165, 38);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(287, 31);
            this.lblDatos.TabIndex = 22;
            this.lblDatos.Text = "Datos de la reserva:";
            // 
            // AltaReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo5_Hotel.Properties.Resources.Marrón_Dorado;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.cmbHabitacion);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.dtpEgreso);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblCantindadHuespedes);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCantHuespedes);
            this.Controls.Add(this.btmLimpiar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.btmAtras);
            this.Name = "AltaReservaForm";
            this.Text = "AltaReservaForm";
            this.Load += new System.EventHandler(this.AltaReservaForm_Load);
            this.VisibleChanged += new System.EventHandler(this.AltaReservaForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmLimpiar;
        private System.Windows.Forms.TextBox txtCantHuespedes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblCantindadHuespedes;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpEgreso;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.Label lblDatos;
    }
}