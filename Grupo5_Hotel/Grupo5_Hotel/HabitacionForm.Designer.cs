namespace Grupo5_Hotel
{
    partial class HabitacionForm
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
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.lblWH = new System.Windows.Forms.Label();
            this.pbWH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToOrderColumns = true;
            this.dataClientes.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.GridColor = System.Drawing.Color.Moccasin;
            this.dataClientes.Location = new System.Drawing.Point(170, 105);
            this.dataClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.RowHeadersWidth = 62;
            this.dataClientes.RowTemplate.Height = 28;
            this.dataClientes.Size = new System.Drawing.Size(386, 252);
            this.dataClientes.TabIndex = 7;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Moccasin;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(31, 335);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 34);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "VOLVER";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Moccasin;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(11, 149);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(118, 34);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cmbHotel
            // 
            this.cmbHotel.BackColor = System.Drawing.Color.Moccasin;
            this.cmbHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(11, 122);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(123, 21);
            this.cmbHotel.TabIndex = 8;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHoteles_SelectedIndexChanged);
            this.cmbHotel.Click += new System.EventHandler(this.cmbHotel_Click);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.BackColor = System.Drawing.Color.Transparent;
            this.lblHotel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.ForeColor = System.Drawing.Color.Moccasin;
            this.lblHotel.Location = new System.Drawing.Point(11, 102);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(60, 18);
            this.lblHotel.TabIndex = 9;
            this.lblHotel.Text = "Hotel:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblHabitaciones.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.ForeColor = System.Drawing.Color.Moccasin;
            this.lblHabitaciones.Location = new System.Drawing.Point(165, 38);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(208, 31);
            this.lblHabitaciones.TabIndex = 10;
            this.lblHabitaciones.Text = "Habitaciones:";
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.BackColor = System.Drawing.Color.Transparent;
            this.lblWH.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWH.ForeColor = System.Drawing.Color.White;
            this.lblWH.Location = new System.Drawing.Point(21, 68);
            this.lblWH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(94, 15);
            this.lblWH.TabIndex = 32;
            this.lblWH.Text = "WHITE HAT\r\n";
            // 
            // pbWH
            // 
            this.pbWH.BackColor = System.Drawing.Color.Transparent;
            this.pbWH.Image = global::Grupo5_Hotel.Properties.Resources.Sombrero_vaquero_blanco;
            this.pbWH.Location = new System.Drawing.Point(18, 18);
            this.pbWH.Name = "pbWH";
            this.pbWH.Size = new System.Drawing.Size(100, 47);
            this.pbWH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWH.TabIndex = 31;
            this.pbWH.TabStop = false;
            // 
            // HabitacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo5_Hotel.Properties.Resources.Marrón_Dorado;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.lblWH);
            this.Controls.Add(this.pbWH);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAlta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HabitacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HabitacionForm";
            this.Load += new System.EventHandler(this.HabitacionForm_Load);
            this.VisibleChanged += new System.EventHandler(this.HabitacionForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.PictureBox pbWH;
    }
}