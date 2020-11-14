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
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonListar
            // 
            this.BotonListar.Location = new System.Drawing.Point(25, 141);
            this.BotonListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonListar.Name = "BotonListar";
            this.BotonListar.Size = new System.Drawing.Size(128, 58);
            this.BotonListar.TabIndex = 1;
            this.BotonListar.Text = "Listar Hoteles";
            this.BotonListar.UseVisualStyleBackColor = true;
            this.BotonListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 236);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 59);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Hotel";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(26, 468);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(127, 51);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dataHotel
            // 
            this.dataHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHotel.Location = new System.Drawing.Point(194, 56);
            this.dataHotel.Name = "dataHotel";
            this.dataHotel.RowHeadersVisible = false;
            this.dataHotel.RowHeadersWidth = 62;
            this.dataHotel.RowTemplate.Height = 28;
            this.dataHotel.Size = new System.Drawing.Size(959, 408);
            this.dataHotel.TabIndex = 4;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 562);
            this.Controls.Add(this.dataHotel);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BotonListar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HotelForm";
            this.Text = "HotelesForm";
            this.Load += new System.EventHandler(this.HotelesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotonListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataHoteles;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dataHotel;
    }
}