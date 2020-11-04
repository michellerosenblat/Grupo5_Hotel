namespace Grupo5_Hotel
{
    partial class HotelesForm
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
            this.ListHoteles = new System.Windows.Forms.ListBox();
            this.BotonListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListHoteles
            // 
            this.ListHoteles.FormattingEnabled = true;
            this.ListHoteles.ItemHeight = 20;
            this.ListHoteles.Location = new System.Drawing.Point(195, 141);
            this.ListHoteles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListHoteles.Name = "ListHoteles";
            this.ListHoteles.Size = new System.Drawing.Size(940, 244);
            this.ListHoteles.TabIndex = 0;
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
            // HotelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 562);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BotonListar);
            this.Controls.Add(this.ListHoteles);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HotelesForm";
            this.Text = "HotelesForm";
            this.Load += new System.EventHandler(this.HotelesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListHoteles;
        private System.Windows.Forms.Button BotonListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataHoteles;
    }
}