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
            this.txtboxCliente = new System.Windows.Forms.TextBox();
            this.txtboxHabitacion = new System.Windows.Forms.TextBox();
            this.txtboxHuespedes = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblCantindadHuespedes = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpEgreso = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btmAtras
            // 
            this.btmAtras.Location = new System.Drawing.Point(32, 472);
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
            this.btmAgregar.Location = new System.Drawing.Point(426, 472);
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
            this.btmLimpiar.Location = new System.Drawing.Point(812, 472);
            this.btmLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btmLimpiar.TabIndex = 2;
            this.btmLimpiar.Text = "Limpiar campos";
            this.btmLimpiar.UseVisualStyleBackColor = true;
            this.btmLimpiar.Click += new System.EventHandler(this.btmLimpiar_Click);
            // 
            // txtboxCliente
            // 
            this.txtboxCliente.Location = new System.Drawing.Point(300, 72);
            this.txtboxCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCliente.Name = "txtboxCliente";
            this.txtboxCliente.Size = new System.Drawing.Size(280, 26);
            this.txtboxCliente.TabIndex = 3;
            // 
            // txtboxHabitacion
            // 
            this.txtboxHabitacion.Location = new System.Drawing.Point(300, 171);
            this.txtboxHabitacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxHabitacion.Name = "txtboxHabitacion";
            this.txtboxHabitacion.Size = new System.Drawing.Size(278, 26);
            this.txtboxHabitacion.TabIndex = 4;
            // 
            // txtboxHuespedes
            // 
            this.txtboxHuespedes.Location = new System.Drawing.Point(300, 272);
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
            this.lblHabitacion.Location = new System.Drawing.Point(405, 128);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(85, 20);
            this.lblHabitacion.TabIndex = 10;
            this.lblHabitacion.Text = "Habitación";
            // 
            // lblCantindadHuespedes
            // 
            this.lblCantindadHuespedes.AutoSize = true;
            this.lblCantindadHuespedes.Location = new System.Drawing.Point(357, 229);
            this.lblCantindadHuespedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantindadHuespedes.Name = "lblCantindadHuespedes";
            this.lblCantindadHuespedes.Size = new System.Drawing.Size(181, 20);
            this.lblCantindadHuespedes.TabIndex = 11;
            this.lblCantindadHuespedes.Text = "Cantidad de Huespedes";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(198, 347);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(134, 20);
            this.lblIngreso.TabIndex = 12;
            this.lblIngreso.Text = "Fecha de Ingreso";
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Location = new System.Drawing.Point(538, 347);
            this.lblEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(131, 20);
            this.lblEgreso.TabIndex = 13;
            this.lblEgreso.Text = "Fecha de Egreso";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(112, 392);
            this.dtpIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(298, 26);
            this.dtpIngreso.TabIndex = 16;
            // 
            // dtpEgreso
            // 
            this.dtpEgreso.Location = new System.Drawing.Point(462, 392);
            this.dtpEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEgreso.Name = "dtpEgreso";
            this.dtpEgreso.Size = new System.Drawing.Size(298, 26);
            this.dtpEgreso.TabIndex = 17;
            // 
            // AltaReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 553);
            this.Controls.Add(this.dtpEgreso);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblCantindadHuespedes);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtboxHuespedes);
            this.Controls.Add(this.txtboxHabitacion);
            this.Controls.Add(this.txtboxCliente);
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
        private System.Windows.Forms.TextBox txtboxCliente;
        private System.Windows.Forms.TextBox txtboxHabitacion;
        private System.Windows.Forms.TextBox txtboxHuespedes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblCantindadHuespedes;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpEgreso;
    }
}