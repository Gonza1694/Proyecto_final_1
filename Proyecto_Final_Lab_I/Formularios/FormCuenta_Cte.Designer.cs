namespace Proyecto_Final_Lab_I
{
    partial class FormCuenta_Cte
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
            this.lbl_titulo_ctacte = new System.Windows.Forms.Label();
            this.bnt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo_ctacte
            // 
            this.lbl_titulo_ctacte.AutoSize = true;
            this.lbl_titulo_ctacte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo_ctacte.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo_ctacte.Location = new System.Drawing.Point(418, 9);
            this.lbl_titulo_ctacte.Name = "lbl_titulo_ctacte";
            this.lbl_titulo_ctacte.Size = new System.Drawing.Size(195, 29);
            this.lbl_titulo_ctacte.TabIndex = 1;
            this.lbl_titulo_ctacte.Text = "Cuenta Corriente";
            // 
            // bnt_cancelar
            // 
            this.bnt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bnt_cancelar.FlatAppearance.BorderSize = 3;
            this.bnt_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bnt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_cancelar.ForeColor = System.Drawing.Color.Tomato;
            this.bnt_cancelar.Location = new System.Drawing.Point(887, 532);
            this.bnt_cancelar.Name = "bnt_cancelar";
            this.bnt_cancelar.Size = new System.Drawing.Size(151, 66);
            this.bnt_cancelar.TabIndex = 8;
            this.bnt_cancelar.Text = "Cancelar";
            this.bnt_cancelar.UseVisualStyleBackColor = true;
            this.bnt_cancelar.Click += new System.EventHandler(this.bnt_cancelar_Click);
            // 
            // FormCuenta_Cte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.bnt_cancelar);
            this.Controls.Add(this.lbl_titulo_ctacte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCuenta_Cte";
            this.Text = "FormCuenta_Cte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_ctacte;
        private System.Windows.Forms.Button bnt_cancelar;
    }
}