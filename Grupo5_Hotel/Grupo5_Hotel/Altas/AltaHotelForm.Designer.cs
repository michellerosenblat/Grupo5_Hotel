namespace Grupo5_Hotel
{
    partial class AltaHotelForm
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEstrellas = new System.Windows.Forms.Label();
            this.lblAmenities = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.comboEstrellas = new System.Windows.Forms.ComboBox();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.panelAmenities = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblWH = new System.Windows.Forms.Label();
            this.pbWH = new System.Windows.Forms.PictureBox();
            this.panelAmenities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWH)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.Moccasin;
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(423, 168);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(299, 30);
            this.textNombre.TabIndex = 0;
            // 
            // textDireccion
            // 
            this.textDireccion.BackColor = System.Drawing.Color.Moccasin;
            this.textDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDireccion.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(423, 232);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(299, 30);
            this.textDireccion.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Moccasin;
            this.lblNombre.Location = new System.Drawing.Point(267, 172);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Moccasin;
            this.lblDireccion.Location = new System.Drawing.Point(267, 234);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(111, 24);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.BackColor = System.Drawing.Color.Transparent;
            this.lblEstrellas.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrellas.ForeColor = System.Drawing.Color.Moccasin;
            this.lblEstrellas.Location = new System.Drawing.Point(267, 288);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(99, 24);
            this.lblEstrellas.TabIndex = 7;
            this.lblEstrellas.Text = "Estrellas";
            // 
            // lblAmenities
            // 
            this.lblAmenities.AutoSize = true;
            this.lblAmenities.BackColor = System.Drawing.Color.Transparent;
            this.lblAmenities.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenities.ForeColor = System.Drawing.Color.Moccasin;
            this.lblAmenities.Location = new System.Drawing.Point(267, 375);
            this.lblAmenities.Name = "lblAmenities";
            this.lblAmenities.Size = new System.Drawing.Size(113, 24);
            this.lblAmenities.TabIndex = 8;
            this.lblAmenities.Text = "Amenities";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(16, 157);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(177, 52);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Moccasin;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVolver.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(44, 534);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(135, 52);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "VOLVER";
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // comboEstrellas
            // 
            this.comboEstrellas.BackColor = System.Drawing.Color.Moccasin;
            this.comboEstrellas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboEstrellas.FormattingEnabled = true;
            this.comboEstrellas.Location = new System.Drawing.Point(423, 286);
            this.comboEstrellas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboEstrellas.Name = "comboEstrellas";
            this.comboEstrellas.Size = new System.Drawing.Size(298, 28);
            this.comboEstrellas.TabIndex = 11;
            this.comboEstrellas.SelectedIndexChanged += new System.EventHandler(this.comboEstrellas_SelectedIndexChanged);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.ForeColor = System.Drawing.Color.Moccasin;
            this.rbSi.Location = new System.Drawing.Point(24, 17);
            this.rbSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(52, 28);
            this.rbSi.TabIndex = 0;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.ForeColor = System.Drawing.Color.Moccasin;
            this.rbNo.Location = new System.Drawing.Point(116, 17);
            this.rbNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(61, 28);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // panelAmenities
            // 
            this.panelAmenities.BackColor = System.Drawing.Color.Transparent;
            this.panelAmenities.Controls.Add(this.rbSi);
            this.panelAmenities.Controls.Add(this.rbNo);
            this.panelAmenities.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAmenities.Location = new System.Drawing.Point(465, 352);
            this.panelAmenities.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelAmenities.Name = "panelAmenities";
            this.panelAmenities.Size = new System.Drawing.Size(202, 60);
            this.panelAmenities.TabIndex = 13;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Moccasin;
            this.lblDatos.Location = new System.Drawing.Point(248, 58);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(347, 47);
            this.lblDatos.TabIndex = 14;
            this.lblDatos.Text = "Datos del hotel:";
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.BackColor = System.Drawing.Color.Transparent;
            this.lblWH.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWH.ForeColor = System.Drawing.Color.White;
            this.lblWH.Location = new System.Drawing.Point(32, 105);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(139, 22);
            this.lblWH.TabIndex = 38;
            this.lblWH.Text = "WHITE HAT\r\n";
            // 
            // pbWH
            // 
            this.pbWH.BackColor = System.Drawing.Color.Transparent;
            this.pbWH.Image = global::Grupo5_Hotel.Properties.Resources.Sombrero_vaquero_blanco;
            this.pbWH.Location = new System.Drawing.Point(27, 28);
            this.pbWH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbWH.Name = "pbWH";
            this.pbWH.Size = new System.Drawing.Size(150, 72);
            this.pbWH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWH.TabIndex = 37;
            this.pbWH.TabStop = false;
            // 
            // AltaHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupo5_Hotel.Properties.Resources.Marrón_Dorado;
            this.ClientSize = new System.Drawing.Size(876, 603);
            this.Controls.Add(this.lblWH);
            this.Controls.Add(this.pbWH);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.comboEstrellas);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.lblAmenities);
            this.Controls.Add(this.lblEstrellas);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.panelAmenities);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AltaHotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarHotel";
            this.Load += new System.EventHandler(this.AltaHotelForm_Load);
            this.panelAmenities.ResumeLayout(false);
            this.panelAmenities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEstrellas;
        private System.Windows.Forms.Label lblAmenities;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.ComboBox comboEstrellas;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Panel panelAmenities;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.PictureBox pbWH;
    }
}