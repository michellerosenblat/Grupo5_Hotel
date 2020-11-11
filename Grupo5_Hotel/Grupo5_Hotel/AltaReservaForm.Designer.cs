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
            this.txtboxHuespedes = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblCantindadHuespedes = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpEgreso = new System.Windows.Forms.DateTimePicker();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btmAtras
            // 
            this.btmAtras.Location = new System.Drawing.Point(32, 540);
            this.btmAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(112, 35);
            this.btmAtras.TabIndex = 0;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = true;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(426, 540);
            this.btmAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(112, 35);
            this.btmAgregar.TabIndex = 1;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.Location = new System.Drawing.Point(812, 540);
            this.btmLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btmLimpiar.TabIndex = 2;
            this.btmLimpiar.Text = "Limpiar campos";
            this.btmLimpiar.UseVisualStyleBackColor = true;
            this.btmLimpiar.Click += new System.EventHandler(this.btmLimpiar_Click);
            // 
            // txtboxHuespedes
            // 
            this.txtboxHuespedes.Location = new System.Drawing.Point(300, 340);
            this.txtboxHuespedes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxHuespedes.Name = "txtboxHuespedes";
            this.txtboxHuespedes.Size = new System.Drawing.Size(278, 26);
            this.txtboxHuespedes.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(408, 31);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(405, 196);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(85, 20);
            this.lblHabitacion.TabIndex = 10;
            this.lblHabitacion.Text = "Habitación";
            // 
            // lblCantindadHuespedes
            // 
            this.lblCantindadHuespedes.AutoSize = true;
            this.lblCantindadHuespedes.Location = new System.Drawing.Point(357, 297);
            this.lblCantindadHuespedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantindadHuespedes.Name = "lblCantindadHuespedes";
            this.lblCantindadHuespedes.Size = new System.Drawing.Size(181, 20);
            this.lblCantindadHuespedes.TabIndex = 11;
            this.lblCantindadHuespedes.Text = "Cantidad de Huespedes";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(198, 416);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(134, 20);
            this.lblIngreso.TabIndex = 12;
            this.lblIngreso.Text = "Fecha de Ingreso";
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Location = new System.Drawing.Point(538, 416);
            this.lblEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(131, 20);
            this.lblEgreso.TabIndex = 13;
            this.lblEgreso.Text = "Fecha de Egreso";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(112, 460);
            this.dtpIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(298, 26);
            this.dtpIngreso.TabIndex = 16;
            // 
            // dtpEgreso
            // 
            this.dtpEgreso.Location = new System.Drawing.Point(462, 460);
            this.dtpEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEgreso.Name = "dtpEgreso";
            this.dtpEgreso.Size = new System.Drawing.Size(298, 26);
            this.dtpEgreso.TabIndex = 17;
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(324, 65);
            this.comboClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(240, 28);
            this.comboClientes.TabIndex = 18;
            this.comboClientes.Click += new System.EventHandler(this.comboClientes_Click);
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(324, 240);
            this.cmbHabitacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(240, 28);
            this.cmbHabitacion.TabIndex = 19;
            this.cmbHabitacion.SelectedIndexChanged += new System.EventHandler(this.cmbHabitacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hotel";
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(324, 156);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(240, 28);
            this.cmbHotel.TabIndex = 21;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            this.cmbHotel.Click += new System.EventHandler(this.cmbHotel_Click);
            // 
            // AltaReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 597);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHabitacion);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.dtpEgreso);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblCantindadHuespedes);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtboxHuespedes);
            this.Controls.Add(this.btmLimpiar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.btmAtras);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AltaReservaForm";
            this.Text = "AltaReservaForm";
            this.Load += new System.EventHandler(this.AltaReservaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmLimpiar;
        private System.Windows.Forms.TextBox txtboxHuespedes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblCantindadHuespedes;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpEgreso;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHotel;
    }
}