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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.AllowUserToOrderColumns = true;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Location = new System.Drawing.Point(262, 84);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.ReadOnly = true;
            this.dataClientes.RowHeadersVisible = false;
            this.dataClientes.RowHeadersWidth = 62;
            this.dataClientes.RowTemplate.Height = 28;
            this.dataClientes.Size = new System.Drawing.Size(901, 387);
            this.dataClientes.TabIndex = 7;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(78, 369);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(139, 57);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(78, 187);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(139, 58);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Alta Habitaciones";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(50, 121);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(182, 28);
            this.cmbHotel.TabIndex = 8;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHoteles_SelectedIndexChanged);
            this.cmbHotel.Click += new System.EventHandler(this.cmbHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hotel";
            // 
            // HabitacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAlta);
            this.Name = "HabitacionForm";
            this.Text = "HabitacionForm";
            this.Load += new System.EventHandler(this.HabitacionForm_Load);
            this.VisibleChanged += new System.EventHandler(this.HabitacionForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.Label label1;
    }
}