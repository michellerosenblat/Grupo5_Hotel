namespace Grupo5_Hotel
{
    partial class Menu
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btmReporteReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(187, 53);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(118, 32);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(187, 107);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(118, 35);
            this.btnReserva.TabIndex = 1;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(187, 166);
            this.btnHotel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(118, 34);
            this.btnHotel.TabIndex = 2;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.Location = new System.Drawing.Point(187, 218);
            this.btnHabitacion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(118, 32);
            this.btnHabitacion.TabIndex = 3;
            this.btnHabitacion.Text = "Habitación";
            this.btnHabitacion.UseVisualStyleBackColor = true;
            this.btnHabitacion.Click += new System.EventHandler(this.btnHabitacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija una opción de menú";
            // 
            // btmReporteReserva
            // 
            this.btmReporteReserva.Location = new System.Drawing.Point(319, 113);
            this.btmReporteReserva.Name = "btmReporteReserva";
            this.btmReporteReserva.Size = new System.Drawing.Size(149, 23);
            this.btmReporteReserva.TabIndex = 5;
            this.btmReporteReserva.Text = "Reporte de Reservas";
            this.btmReporteReserva.UseVisualStyleBackColor = true;
            this.btmReporteReserva.Click += new System.EventHandler(this.btmReporteReserva_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btmReporteReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHabitacion);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.btnCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmReporteReserva;
    }
}

