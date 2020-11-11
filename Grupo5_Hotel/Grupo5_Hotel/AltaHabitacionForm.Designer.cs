namespace Grupo5_Hotel
{
    partial class AltaHabitacionForm
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
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.Hotel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlazas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.Precio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCancelable = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelCancelable = new System.Windows.Forms.Panel();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelCancelable.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(325, 75);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(121, 28);
            this.cmbHotel.TabIndex = 0;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            this.cmbHotel.Click += new System.EventHandler(this.cmbHotel_Click);
            // 
            // Hotel
            // 
            this.Hotel.AutoSize = true;
            this.Hotel.Location = new System.Drawing.Point(358, 34);
            this.Hotel.Name = "Hotel";
            this.Hotel.Size = new System.Drawing.Size(47, 20);
            this.Hotel.TabIndex = 1;
            this.Hotel.Text = "Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad plazas";
            // 
            // cmbPlazas
            // 
            this.cmbPlazas.FormattingEnabled = true;
            this.cmbPlazas.Location = new System.Drawing.Point(325, 173);
            this.cmbPlazas.Name = "cmbPlazas";
            this.cmbPlazas.Size = new System.Drawing.Size(121, 28);
            this.cmbPlazas.TabIndex = 3;
            this.cmbPlazas.SelectedIndexChanged += new System.EventHandler(this.cmbPlazas_SelectedIndexChanged);
            this.cmbPlazas.Click += new System.EventHandler(this.cmbPlazas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(325, 265);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 28);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.Click += new System.EventHandler(this.cmbCategoria_Click);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(353, 315);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(53, 20);
            this.Precio.TabIndex = 6;
            this.Precio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(327, 354);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 26);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblCancelable
            // 
            this.lblCancelable.AutoSize = true;
            this.lblCancelable.Location = new System.Drawing.Point(339, 410);
            this.lblCancelable.Name = "lblCancelable";
            this.lblCancelable.Size = new System.Drawing.Size(88, 20);
            this.lblCancelable.TabIndex = 8;
            this.lblCancelable.Text = "Cancelable";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(612, 486);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 38);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(28, 472);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(109, 38);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panelCancelable
            // 
            this.panelCancelable.Controls.Add(this.rbSi);
            this.panelCancelable.Controls.Add(this.rbNo);
            this.panelCancelable.Location = new System.Drawing.Point(284, 434);
            this.panelCancelable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCancelable.Name = "panelCancelable";
            this.panelCancelable.Size = new System.Drawing.Size(202, 60);
            this.panelCancelable.TabIndex = 14;
            this.panelCancelable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCancelable_Paint);
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
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(756, 486);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 38);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // AltaHabitacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 536);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panelCancelable);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCancelable);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPlazas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hotel);
            this.Controls.Add(this.cmbHotel);
            this.Name = "AltaHabitacionForm";
            this.Text = "AltaHabitacionForm";
            this.Load += new System.EventHandler(this.AltaHabitacionForm_Load);
            this.panelCancelable.ResumeLayout(false);
            this.panelCancelable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.Label Hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlazas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCancelable;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panelCancelable;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}