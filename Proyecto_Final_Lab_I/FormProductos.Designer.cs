namespace Proyecto_Final_Lab_I
{
    partial class FormProductos
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
            this.lbl_titulo_productos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo_productos
            // 
            this.lbl_titulo_productos.AutoSize = true;
            this.lbl_titulo_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo_productos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo_productos.Location = new System.Drawing.Point(463, 9);
            this.lbl_titulo_productos.Name = "lbl_titulo_productos";
            this.lbl_titulo_productos.Size = new System.Drawing.Size(122, 29);
            this.lbl_titulo_productos.TabIndex = 2;
            this.lbl_titulo_productos.Text = "Productos";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.lbl_titulo_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_productos;
    }
}