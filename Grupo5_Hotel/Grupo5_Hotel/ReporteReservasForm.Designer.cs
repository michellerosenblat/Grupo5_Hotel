namespace Grupo5_Hotel
{
    partial class ReporteReservasForm
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dataReserva = new System.Windows.Forms.DataGridView();
            this.btmAtras = new System.Windows.Forms.Button();
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.lblNroReservas = new System.Windows.Forms.Label();
            this.txtNroReservas = new System.Windows.Forms.TextBox();
            this.txtNroClientes = new System.Windows.Forms.TextBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.lbllinea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCliente.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Moccasin;
            this.lblCliente.Location = new System.Drawing.Point(267, 286);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(82, 24);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.Moccasin;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(414, 285);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(250, 28);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // dataReserva
            // 
            this.dataReserva.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReserva.GridColor = System.Drawing.Color.Moccasin;
            this.dataReserva.Location = new System.Drawing.Point(255, 326);
            this.dataReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataReserva.Name = "dataReserva";
            this.dataReserva.RowHeadersWidth = 62;
            this.dataReserva.Size = new System.Drawing.Size(579, 223);
            this.dataReserva.TabIndex = 2;
            // 
            // btmAtras
            // 
            this.btmAtras.BackColor = System.Drawing.Color.Moccasin;
            this.btmAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAtras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtras.Location = new System.Drawing.Point(44, 534);
            this.btmAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(135, 52);
            this.btmAtras.TabIndex = 3;
            this.btmAtras.Text = "VOLVER";
            this.btmAtras.UseVisualStyleBackColor = false;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // lblTotalReservas
            // 
            this.lblTotalReservas.AutoSize = true;
            this.lblTotalReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReservas.ForeColor = System.Drawing.Color.Moccasin;
            this.lblTotalReservas.Location = new System.Drawing.Point(250, 196);
            this.lblTotalReservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(194, 25);
            this.lblTotalReservas.TabIndex = 4;
            this.lblTotalReservas.Text = "Total de Reservas:";
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.ForeColor = System.Drawing.Color.Moccasin;
            this.lblTotalClientes.Location = new System.Drawing.Point(250, 152);
            this.lblTotalClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(307, 24);
            this.lblTotalClientes.TabIndex = 5;
            this.lblTotalClientes.Text = "Total de clientes con reserva:";
            // 
            // lblNroReservas
            // 
            this.lblNroReservas.AutoSize = true;
            this.lblNroReservas.Location = new System.Drawing.Point(206, 146);
            this.lblNroReservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroReservas.Name = "lblNroReservas";
            this.lblNroReservas.Size = new System.Drawing.Size(0, 20);
            this.lblNroReservas.TabIndex = 6;
            // 
            // txtNroReservas
            // 
            this.txtNroReservas.BackColor = System.Drawing.Color.Moccasin;
            this.txtNroReservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroReservas.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroReservas.Location = new System.Drawing.Point(621, 191);
            this.txtNroReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroReservas.Name = "txtNroReservas";
            this.txtNroReservas.Size = new System.Drawing.Size(44, 30);
            this.txtNroReservas.TabIndex = 7;
            // 
            // txtNroClientes
            // 
            this.txtNroClientes.BackColor = System.Drawing.Color.Moccasin;
            this.txtNroClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroClientes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroClientes.Location = new System.Drawing.Point(621, 146);
            this.txtNroClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroClientes.Name = "txtNroClientes";
            this.txtNroClientes.Size = new System.Drawing.Size(44, 30);
            this.txtNroClientes.TabIndex = 8;
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.Color.Moccasin;
            this.lblReporte.Location = new System.Drawing.Point(238, 48);
            this.lblReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(494, 55);
            this.lblReporte.TabIndex = 9;
            this.lblReporte.Text = "Reporte de reservas:";
            // 
            // lbllinea
            // 
            this.lbllinea.AutoSize = true;
            this.lbllinea.ForeColor = System.Drawing.Color.Moccasin;
            this.lbllinea.Location = new System.Drawing.Point(250, 260);
            this.lbllinea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea.Name = "lbllinea";
            this.lbllinea.Size = new System.Drawing.Size(644, 20);
            this.lbllinea.TabIndex = 12;
            this.lbllinea.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------";
            // 
            // ReporteReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo5_Hotel.Properties.Resources.Marrón_Dorado;
            this.ClientSize = new System.Drawing.Size(876, 603);
            this.Controls.Add(this.lbllinea);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.txtNroClientes);
            this.Controls.Add(this.txtNroReservas);
            this.Controls.Add(this.lblNroReservas);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.lblTotalReservas);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.dataReserva);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReporteReservasForm";
            this.Text = "ReporteReservasForm";
            this.Load += new System.EventHandler(this.ReporteReservasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridView dataReserva;
        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.Label lblTotalReservas;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label lblNroReservas;
        private System.Windows.Forms.TextBox txtNroReservas;
        private System.Windows.Forms.TextBox txtNroClientes;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Label lbllinea;
    }
}