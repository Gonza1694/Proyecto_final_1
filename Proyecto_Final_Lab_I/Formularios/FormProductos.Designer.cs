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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo_productos = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.dgv_busquedaProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busquedaProd)).BeginInit();
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
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 2;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_agregar.Location = new System.Drawing.Point(12, 401);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(106, 37);
            this.btn_agregar.TabIndex = 15;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(135, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 12;
            this.lineShape3.X2 = 236;
            this.lineShape3.Y1 = 186;
            this.lineShape3.Y2 = 186;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2,
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(1050, 610);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 13;
            this.lineShape4.X2 = 237;
            this.lineShape4.Y1 = 321;
            this.lineShape4.Y2 = 321;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 14;
            this.lineShape2.X2 = 238;
            this.lineShape2.Y1 = 277;
            this.lineShape2.Y2 = 277;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 237;
            this.lineShape1.Y1 = 233;
            this.lineShape1.Y2 = 233;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descripcion.Location = new System.Drawing.Point(12, 164);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(293, 15);
            this.txt_descripcion.TabIndex = 18;
            this.txt_descripcion.Text = "Descripcion";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.Location = new System.Drawing.Point(12, 211);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(293, 15);
            this.txt_codigo.TabIndex = 19;
            this.txt_codigo.Text = "Código de producto";
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precio.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_precio.Location = new System.Drawing.Point(12, 253);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(293, 15);
            this.txt_precio.TabIndex = 20;
            this.txt_precio.Text = "Precio";
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stock.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_stock.Location = new System.Drawing.Point(12, 298);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(293, 15);
            this.txt_stock.TabIndex = 21;
            this.txt_stock.Text = "Stock";
            // 
            // dgv_busquedaProd
            // 
            this.dgv_busquedaProd.AllowUserToResizeColumns = false;
            this.dgv_busquedaProd.AllowUserToResizeRows = false;
            this.dgv_busquedaProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_busquedaProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgv_busquedaProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_busquedaProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_busquedaProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busquedaProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_busquedaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_busquedaProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_busquedaProd.EnableHeadersVisualStyles = false;
            this.dgv_busquedaProd.GridColor = System.Drawing.Color.LightGreen;
            this.dgv_busquedaProd.Location = new System.Drawing.Point(403, 137);
            this.dgv_busquedaProd.Name = "dgv_busquedaProd";
            this.dgv_busquedaProd.ReadOnly = true;
            this.dgv_busquedaProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busquedaProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_busquedaProd.RowHeadersVisible = false;
            this.dgv_busquedaProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_busquedaProd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_busquedaProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_busquedaProd.Size = new System.Drawing.Size(604, 433);
            this.dgv_busquedaProd.TabIndex = 22;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.dgv_busquedaProd);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_titulo_productos);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busquedaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_productos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_precio;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.DataGridView dgv_busquedaProd;
    }
}