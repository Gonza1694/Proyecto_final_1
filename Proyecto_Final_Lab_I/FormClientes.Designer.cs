namespace Proyecto_Final_Lab_I
{
    partial class FormClientes
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
            this.lbl_titulo_clientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo_clientes
            // 
            this.lbl_titulo_clientes.AutoSize = true;
            this.lbl_titulo_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo_clientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo_clientes.Location = new System.Drawing.Point(461, 9);
            this.lbl_titulo_clientes.Name = "lbl_titulo_clientes";
            this.lbl_titulo_clientes.Size = new System.Drawing.Size(101, 29);
            this.lbl_titulo_clientes.TabIndex = 1;
            this.lbl_titulo_clientes.Text = "Clientes";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.lbl_titulo_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_clientes;
    }
}