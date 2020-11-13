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
            ((System.ComponentModel.ISupportInitialize)(this.dataReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCliente.Location = new System.Drawing.Point(280, 37);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(338, 34);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // dataReserva
            // 
            this.dataReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReserva.Location = new System.Drawing.Point(283, 77);
            this.dataReserva.Name = "dataReserva";
            this.dataReserva.Size = new System.Drawing.Size(473, 315);
            this.dataReserva.TabIndex = 2;
            // 
            // btmAtras
            // 
            this.btmAtras.Location = new System.Drawing.Point(82, 369);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(75, 23);
            this.btmAtras.TabIndex = 3;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = true;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // lblTotalReservas
            // 
            this.lblTotalReservas.AutoSize = true;
            this.lblTotalReservas.Location = new System.Drawing.Point(40, 122);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(97, 13);
            this.lblTotalReservas.TabIndex = 4;
            this.lblTotalReservas.Text = "Total de Reservas:";
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Location = new System.Drawing.Point(40, 95);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(147, 13);
            this.lblTotalClientes.TabIndex = 5;
            this.lblTotalClientes.Text = "Total de clientes con reserva:";
            // 
            // lblNroReservas
            // 
            this.lblNroReservas.AutoSize = true;
            this.lblNroReservas.Location = new System.Drawing.Point(137, 95);
            this.lblNroReservas.Name = "lblNroReservas";
            this.lblNroReservas.Size = new System.Drawing.Size(0, 13);
            this.lblNroReservas.TabIndex = 6;
            // 
            // txtNroReservas
            // 
            this.txtNroReservas.Location = new System.Drawing.Point(143, 119);
            this.txtNroReservas.Name = "txtNroReservas";
            this.txtNroReservas.Size = new System.Drawing.Size(30, 20);
            this.txtNroReservas.TabIndex = 7;
            // 
            // txtNroClientes
            // 
            this.txtNroClientes.Location = new System.Drawing.Point(193, 95);
            this.txtNroClientes.Name = "txtNroClientes";
            this.txtNroClientes.Size = new System.Drawing.Size(30, 20);
            this.txtNroClientes.TabIndex = 8;
            // 
            // ReporteReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNroClientes);
            this.Controls.Add(this.txtNroReservas);
            this.Controls.Add(this.lblNroReservas);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.lblTotalReservas);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.dataReserva);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
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
    }
}