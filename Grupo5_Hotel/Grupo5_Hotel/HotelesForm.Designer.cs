namespace Grupo5_Hotel
{
    partial class HotelForm
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
            this.BotonListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dataHotel = new System.Windows.Forms.DataGridView();
            this.lblHoteles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonListar
            // 
            this.BotonListar.BackColor = System.Drawing.Color.Moccasin;
            this.BotonListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonListar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonListar.Location = new System.Drawing.Point(16, 157);
            this.BotonListar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BotonListar.Name = "BotonListar";
            this.BotonListar.Size = new System.Drawing.Size(177, 52);
            this.BotonListar.TabIndex = 1;
            this.BotonListar.Text = "LISTAR";
            this.BotonListar.UseVisualStyleBackColor = false;
            this.BotonListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(16, 229);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(177, 52);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "ALTA";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Moccasin;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(44, 534);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(135, 52);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "VOLVER";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dataHotel
            // 
            this.dataHotel.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHotel.GridColor = System.Drawing.Color.Moccasin;
            this.dataHotel.Location = new System.Drawing.Point(256, 109);
            this.dataHotel.Name = "dataHotel";
            this.dataHotel.RowHeadersVisible = false;
            this.dataHotel.RowHeadersWidth = 62;
            this.dataHotel.RowTemplate.Height = 28;
            this.dataHotel.Size = new System.Drawing.Size(576, 458);
            this.dataHotel.TabIndex = 4;
            this.dataHotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHotel_CellContentClick);
            // 
            // lblHoteles
            // 
            this.lblHoteles.AutoSize = true;
            this.lblHoteles.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoteles.ForeColor = System.Drawing.Color.Moccasin;
            this.lblHoteles.Location = new System.Drawing.Point(248, 58);
            this.lblHoteles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoteles.Name = "lblHoteles";
            this.lblHoteles.Size = new System.Drawing.Size(195, 47);
            this.lblHoteles.TabIndex = 5;
            this.lblHoteles.Text = "Hoteles:";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo5_Hotel.Properties.Resources.Marrón_Dorado;
            this.ClientSize = new System.Drawing.Size(876, 603);
            this.Controls.Add(this.lblHoteles);
            this.Controls.Add(this.dataHotel);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BotonListar);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "HotelForm";
            this.Text = "HotelesForm";
            this.Load += new System.EventHandler(this.HotelesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataHoteles;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dataHotel;
        private System.Windows.Forms.Label lblHoteles;
    }
}