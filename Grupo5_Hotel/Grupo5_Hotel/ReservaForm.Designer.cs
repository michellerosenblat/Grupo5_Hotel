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
            ((System.ComponentModel.ISupportInitialize)(this.dataReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarReserva
            // 
            this.btnListarReserva.Location = new System.Drawing.Point(72, 88);
            this.btnListarReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarReserva.Name = "btnListarReserva";
            this.btnListarReserva.Size = new System.Drawing.Size(132, 54);
            this.btnListarReserva.TabIndex = 0;
            this.btnListarReserva.Text = "Listar reservas";
            this.btnListarReserva.UseVisualStyleBackColor = true;
            this.btnListarReserva.Click += new System.EventHandler(this.btnListarReserva_Click);
            // 
            // btmAltaReserva
            // 
            this.btmAltaReserva.Location = new System.Drawing.Point(72, 186);
            this.btmAltaReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmAltaReserva.Name = "btmAltaReserva";
            this.btmAltaReserva.Size = new System.Drawing.Size(132, 51);
            this.btmAltaReserva.TabIndex = 1;
            this.btmAltaReserva.Text = "Alta reserva";
            this.btmAltaReserva.UseVisualStyleBackColor = true;
            this.btmAltaReserva.Click += new System.EventHandler(this.btmAltaReserva_Click_1);
            // 
            // btmAtras
            // 
            this.btmAtras.Location = new System.Drawing.Point(76, 314);
            this.btmAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(126, 65);
            this.btmAtras.TabIndex = 2;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = true;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // dataReserva
            // 
            this.dataReserva.AllowUserToAddRows = false;
            this.dataReserva.AllowUserToDeleteRows = false;
            this.dataReserva.AllowUserToOrderColumns = true;
            this.dataReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReserva.Location = new System.Drawing.Point(228, 38);
            this.dataReserva.Name = "dataReserva";
            this.dataReserva.ReadOnly = true;
            this.dataReserva.RowHeadersVisible = false;
            this.dataReserva.RowHeadersWidth = 62;
            this.dataReserva.RowTemplate.Height = 28;
            this.dataReserva.Size = new System.Drawing.Size(1110, 432);
            this.dataReserva.TabIndex = 8;
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 590);
            this.Controls.Add(this.dataReserva);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.btmAltaReserva);
            this.Controls.Add(this.btnListarReserva);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarReserva;
        private System.Windows.Forms.Button btmAltaReserva;
        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.DataGridView dataReserva;
    }
}