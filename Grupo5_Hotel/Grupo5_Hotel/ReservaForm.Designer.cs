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
            this.button1 = new System.Windows.Forms.Button();
            this.btmAltaReserva = new System.Windows.Forms.Button();
            this.btmAtras = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar reservas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btmAltaReserva
            // 
            this.btmAltaReserva.Location = new System.Drawing.Point(48, 121);
            this.btmAltaReserva.Name = "btmAltaReserva";
            this.btmAltaReserva.Size = new System.Drawing.Size(88, 33);
            this.btmAltaReserva.TabIndex = 1;
            this.btmAltaReserva.Text = "Alta reserva";
            this.btmAltaReserva.UseVisualStyleBackColor = true;
            this.btmAltaReserva.Click += new System.EventHandler(this.btmAltaReserva_Click_1);
            // 
            // btmAtras
            // 
            this.btmAtras.Location = new System.Drawing.Point(51, 204);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(84, 42);
            this.btmAtras.TabIndex = 2;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = true;
            this.btmAtras.Click += new System.EventHandler(this.btmAtras_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(238, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 186);
            this.listBox1.TabIndex = 3;
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 314);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.btmAltaReserva);
            this.Controls.Add(this.button1);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btmAltaReserva;
        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.ListBox listBox1;
    }
}