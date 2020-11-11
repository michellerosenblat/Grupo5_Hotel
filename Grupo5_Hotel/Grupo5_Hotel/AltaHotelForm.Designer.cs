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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmenities = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.comboEstrellas = new System.Windows.Forms.ComboBox();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.panelAmenities = new System.Windows.Forms.Panel();
            this.panelAmenities.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(202, 92);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(202, 26);
            this.textNombre.TabIndex = 0;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(202, 140);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(202, 26);
            this.textDireccion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estrellas";
            // 
            // lblAmenities
            // 
            this.lblAmenities.AutoSize = true;
            this.lblAmenities.Location = new System.Drawing.Point(96, 250);
            this.lblAmenities.Name = "lblAmenities";
            this.lblAmenities.Size = new System.Drawing.Size(79, 20);
            this.lblAmenities.TabIndex = 8;
            this.lblAmenities.Text = "Amenities";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(99, 322);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(107, 42);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(304, 322);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(101, 42);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // comboEstrellas
            // 
            this.comboEstrellas.FormattingEnabled = true;
            this.comboEstrellas.Location = new System.Drawing.Point(202, 192);
            this.comboEstrellas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboEstrellas.Name = "comboEstrellas";
            this.comboEstrellas.Size = new System.Drawing.Size(202, 28);
            this.comboEstrellas.TabIndex = 11;
            this.comboEstrellas.SelectedIndexChanged += new System.EventHandler(this.comboEstrellas_SelectedIndexChanged);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(0, 18);
            this.rbSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(48, 24);
            this.rbSi.TabIndex = 0;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(150, 18);
            this.rbNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(54, 24);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // panelAmenities
            // 
            this.panelAmenities.Controls.Add(this.rbSi);
            this.panelAmenities.Controls.Add(this.rbNo);
            this.panelAmenities.Location = new System.Drawing.Point(202, 230);
            this.panelAmenities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAmenities.Name = "panelAmenities";
            this.panelAmenities.Size = new System.Drawing.Size(202, 60);
            this.panelAmenities.TabIndex = 13;
            this.panelAmenities.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAmenities_Paint);
            // 
            // AltaHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 439);
            this.Controls.Add(this.comboEstrellas);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.lblAmenities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.panelAmenities);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AltaHotelForm";
            this.Text = "AgregarHotel";
            this.Load += new System.EventHandler(this.AltaHotelForm_Load);
            this.panelAmenities.ResumeLayout(false);
            this.panelAmenities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmenities;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.ComboBox comboEstrellas;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Panel panelAmenities;
    }
}