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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListHoteles
            // 
            this.ListHoteles.FormattingEnabled = true;
            this.ListHoteles.ItemHeight = 16;
            this.ListHoteles.Location = new System.Drawing.Point(173, 113);
            this.ListHoteles.Name = "ListHoteles";
            this.ListHoteles.Size = new System.Drawing.Size(836, 196);
            this.ListHoteles.TabIndex = 0;
            // 
            // BotonListar
            // 
            this.BotonListar.Location = new System.Drawing.Point(22, 113);
            this.BotonListar.Name = "BotonListar";
            this.BotonListar.Size = new System.Drawing.Size(114, 46);
            this.BotonListar.TabIndex = 1;
            this.BotonListar.Text = "Listar Hoteles";
            this.BotonListar.UseVisualStyleBackColor = true;
            this.BotonListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar Hotel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HotelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BotonListar);
            this.Controls.Add(this.ListHoteles);
            this.Name = "HotelesForm";
            this.Text = "HotelesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListHoteles;
        private System.Windows.Forms.Button BotonListar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataHoteles;
    }
}