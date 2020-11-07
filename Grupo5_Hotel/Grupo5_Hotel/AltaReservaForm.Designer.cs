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
            this.btmAtras.Location = new System.Drawing.Point(12, 379);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(75, 23);
            this.btmAtras.TabIndex = 0;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = true;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(275, 379);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(75, 23);
            this.btmAgregar.TabIndex = 1;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.Location = new System.Drawing.Point(532, 379);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpiar.TabIndex = 2;
            this.btmLimpiar.Text = "Limpiar campos";
            this.btmLimpiar.UseVisualStyleBackColor = true;
            this.btmLimpiar.Click += new System.EventHandler(this.btmLimpiar_Click);
            // 
            // txtboxCliente
            // 
            this.txtboxCliente.Location = new System.Drawing.Point(200, 47);
            this.txtboxCliente.Name = "txtboxCliente";
            this.txtboxCliente.Size = new System.Drawing.Size(188, 20);
            this.txtboxCliente.TabIndex = 3;
            // 
            // txtboxHabitacion
            // 
            this.txtboxHabitacion.Location = new System.Drawing.Point(200, 111);
            this.txtboxHabitacion.Name = "txtboxHabitacion";
            this.txtboxHabitacion.Size = new System.Drawing.Size(187, 20);
            this.txtboxHabitacion.TabIndex = 4;
            // 
            // txtboxHuespedes
            // 
            this.txtboxHuespedes.Location = new System.Drawing.Point(200, 177);
            this.txtboxHuespedes.Name = "txtboxHuespedes";
            this.txtboxHuespedes.Size = new System.Drawing.Size(187, 20);
            this.txtboxHuespedes.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(272, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(270, 83);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(58, 13);
            this.lblHabitacion.TabIndex = 10;
            this.lblHabitacion.Text = "Habitación";
            // 
            // lblCantindadHuespedes
            // 
            this.lblCantindadHuespedes.AutoSize = true;
            this.lblCantindadHuespedes.Location = new System.Drawing.Point(238, 149);
            this.lblCantindadHuespedes.Name = "lblCantindadHuespedes";
            this.lblCantindadHuespedes.Size = new System.Drawing.Size(121, 13);
            this.lblCantindadHuespedes.TabIndex = 11;
            this.lblCantindadHuespedes.Text = "Cantidad de Huespedes";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(133, 249);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblIngreso.TabIndex = 12;
            this.lblIngreso.Text = "Fecha de Ingreso";
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Location = new System.Drawing.Point(360, 249);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(88, 13);
            this.lblEgreso.TabIndex = 13;
            this.lblEgreso.Text = "Fecha de Egreso";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(76, 278);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpIngreso.TabIndex = 16;
            // 
            // dtpEgreso
            // 
            this.dtpEgreso.Location = new System.Drawing.Point(309, 278);
            this.dtpEgreso.Name = "dtpEgreso";
            this.dtpEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtpEgreso.TabIndex = 17;
            // 
            // AltaReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 414);
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