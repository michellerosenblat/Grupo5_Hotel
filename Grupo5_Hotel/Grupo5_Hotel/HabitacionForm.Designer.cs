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
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbHoteles = new System.Windows.Forms.ComboBox();
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
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(78, 187);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(139, 58);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Alta Habitaciones";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(78, 23);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(139, 58);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Habitaciones";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cmbHoteles
            // 
            this.cmbHoteles.FormattingEnabled = true;
            this.cmbHoteles.Location = new System.Drawing.Point(48, 100);
            this.cmbHoteles.Name = "cmbHoteles";
            this.cmbHoteles.Size = new System.Drawing.Size(182, 28);
            this.cmbHoteles.TabIndex = 8;
            // 
            // HabitacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 554);
            this.Controls.Add(this.cmbHoteles);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnListar);
            this.Name = "HabitacionForm";
            this.Text = "HabitacionForm";
            this.Load += new System.EventHandler(this.HabitacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbHoteles;
    }
}