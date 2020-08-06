namespace Proyecto_Final_Lab_I
{
    partial class FormProveedores
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
            this.lbl_titulo_proveedores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo_proveedores
            // 
            this.lbl_titulo_proveedores.AutoSize = true;
            this.lbl_titulo_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo_proveedores.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo_proveedores.Location = new System.Drawing.Point(462, 9);
            this.lbl_titulo_proveedores.Name = "lbl_titulo_proveedores";
            this.lbl_titulo_proveedores.Size = new System.Drawing.Size(152, 29);
            this.lbl_titulo_proveedores.TabIndex = 1;
            this.lbl_titulo_proveedores.Text = "Proveedores";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.lbl_titulo_proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_proveedores;
    }
}