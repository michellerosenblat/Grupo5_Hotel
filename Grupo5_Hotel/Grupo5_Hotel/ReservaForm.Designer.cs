namespace Grupo5_Hotel
{
    partial class ReservaForm
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
            this.btnListarReserva = new System.Windows.Forms.Button();
            this.btmAltaReserva = new System.Windows.Forms.Button();
            this.btmAtras = new System.Windows.Forms.Button();
            this.dataReserva = new System.Windows.Forms.DataGridView();
            this.lblReservas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarReserva
            // 
            this.btnListarReserva.BackColor = System.Drawing.Color.Moccasin;
            this.btnListarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarReserva.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarReserva.Location = new System.Drawing.Point(11, 102);
            this.btnListarReserva.Name = "btnListarReserva";
            this.btnListarReserva.Size = new System.Drawing.Size(118, 34);
            this.btnListarReserva.TabIndex = 0;
            this.btnListarReserva.Text = "LISTAR";
            this.btnListarReserva.UseVisualStyleBackColor = false;
            this.btnListarReserva.Click += new System.EventHandler(this.btnListarReserva_Click);
            // 
            // btmAltaReserva
            // 
            this.btmAltaReserva.BackColor = System.Drawing.Color.Moccasin;
            this.btmAltaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAltaReserva.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAltaReserva.Location = new System.Drawing.Point(11, 149);
            this.btmAltaReserva.Name = "btmAltaReserva";
            this.btmAltaReserva.Size = new System.Drawing.Size(118, 34);
            this.btmAltaReserva.TabIndex = 1;
            this.btmAltaReserva.Text = "ALTA";
            this.btmAltaReserva.UseVisualStyleBackColor = false;
            this.btmAltaReserva.Click += new System.EventHandler(this.btmAltaReserva_Click_1);
            // 
            // btmAtras
            // 
            this.btmAtras.BackColor = System.Drawing.Color.Moccasin;
            this.btmAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAtras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtras.Location = new System.Drawing.Point(29, 347);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(90, 34);
            this.btmAtras.TabIndex = 2;
            this.btmAtras.Text = "VOLVER";
            this.btmAtras.UseVisualStyleBackColor = false;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // dataReserva
            // 
            this.dataReserva.AllowUserToAddRows = false;
            this.dataReserva.AllowUserToDeleteRows = false;
            this.dataReserva.AllowUserToOrderColumns = true;
            this.dataReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataReserva.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReserva.GridColor = System.Drawing.Color.Moccasin;
            this.dataReserva.Location = new System.Drawing.Point(171, 71);
            this.dataReserva.Margin = new System.Windows.Forms.Padding(2);
            this.dataReserva.Name = "dataReserva";
            this.dataReserva.ReadOnly = true;
            this.dataReserva.RowHeadersVisible = false;
            this.dataReserva.RowHeadersWidth = 62;
            this.dataReserva.RowTemplate.Height = 28;
            this.dataReserva.Size = new System.Drawing.Size(384, 298);
            this.dataReserva.TabIndex = 8;
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.ForeColor = System.Drawing.Color.Moccasin;
            this.lblReservas.Location = new System.Drawing.Point(165, 38);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(149, 31);
            this.lblReservas.TabIndex = 9;
            this.lblReservas.Text = "Reservas:";
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo5_Hotel.Properties.Resources.Marrón_Dorado;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.lblReservas);
            this.Controls.Add(this.dataReserva);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.btmAltaReserva);
            this.Controls.Add(this.btnListarReserva);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarReserva;
        private System.Windows.Forms.Button btmAltaReserva;
        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.DataGridView dataReserva;
        private System.Windows.Forms.Label lblReservas;
    }
}