namespace Proyecto_Final_Lab_I
{
    partial class FormVentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo_venta = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.bnt_cancelar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dgv_busquedaProd = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pb_buscar = new System.Windows.Forms.PictureBox();
            this.dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.lbl_numFac = new System.Windows.Forms.TextBox();
            this.lbl_numFacStr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busquedaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_venta
            // 
            this.lbl_titulo_venta.AutoSize = true;
            this.lbl_titulo_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo_venta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo_venta.Location = new System.Drawing.Point(459, 9);
            this.lbl_titulo_venta.Name = "lbl_titulo_venta";
            this.lbl_titulo_venta.Size = new System.Drawing.Size(74, 29);
            this.lbl_titulo_venta.TabIndex = 0;
            this.lbl_titulo_venta.Text = "Venta";
            this.lbl_titulo_venta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descripcion.Location = new System.Drawing.Point(12, 128);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(293, 15);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.TabStop = false;
            this.txt_descripcion.Text = "Descripción";
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscar.Location = new System.Drawing.Point(12, 278);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(299, 15);
            this.txt_buscar.TabIndex = 4;
            this.txt_buscar.Text = "Buscar";
            this.txt_buscar.TextChanged += new System.EventHandler(this.pb_buscar_Click);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            this.txt_buscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_buscar_MouseDown);
            // 
            // btn_facturar
            // 
            this.btn_facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_facturar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_facturar.FlatAppearance.BorderSize = 3;
            this.btn_facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_facturar.Location = new System.Drawing.Point(887, 532);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(151, 66);
            this.btn_facturar.TabIndex = 6;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
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
            this.bnt_cancelar.Location = new System.Drawing.Point(694, 532);
            this.bnt_cancelar.Name = "bnt_cancelar";
            this.bnt_cancelar.Size = new System.Drawing.Size(151, 66);
            this.bnt_cancelar.TabIndex = 7;
            this.bnt_cancelar.Text = "Cancelar";
            this.bnt_cancelar.UseVisualStyleBackColor = true;
            this.bnt_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1050, 610);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape6.BorderWidth = 2;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 171;
            this.lineShape6.X2 = 308;
            this.lineShape6.Y1 = 185;
            this.lineShape6.Y2 = 185;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape5.BorderWidth = 2;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 12;
            this.lineShape5.X2 = 360;
            this.lineShape5.Y1 = 297;
            this.lineShape5.Y2 = 297;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 11;
            this.lineShape4.X2 = 309;
            this.lineShape4.Y1 = 149;
            this.lineShape4.Y2 = 149;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 11;
            this.lineShape3.X2 = 155;
            this.lineShape3.Y1 = 108;
            this.lineShape3.Y2 = 108;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 150;
            this.lineShape1.Y1 = 185;
            this.lineShape1.Y2 = 185;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad.Location = new System.Drawing.Point(175, 165);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(130, 15);
            this.txt_cantidad.TabIndex = 2;
            this.txt_cantidad.Text = "Cantidad";
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            this.txt_cantidad.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            this.txt_cantidad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseDown);
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_precio.Location = new System.Drawing.Point(13, 165);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(130, 15);
            this.txt_precio.TabIndex = 1;
            this.txt_precio.TabStop = false;
            this.txt_precio.Text = "$ 0.00";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.Location = new System.Drawing.Point(12, 87);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(293, 15);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.Text = "Código del producto";
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            this.txt_codigo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_codigo_MouseDown);
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busquedaProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_busquedaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_busquedaProd.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_busquedaProd.EnableHeadersVisualStyles = false;
            this.dgv_busquedaProd.GridColor = System.Drawing.Color.LightGreen;
            this.dgv_busquedaProd.Location = new System.Drawing.Point(12, 307);
            this.dgv_busquedaProd.Name = "dgv_busquedaProd";
            this.dgv_busquedaProd.ReadOnly = true;
            this.dgv_busquedaProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_busquedaProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_busquedaProd.RowHeadersVisible = false;
            this.dgv_busquedaProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_busquedaProd.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_busquedaProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_busquedaProd.Size = new System.Drawing.Size(395, 291);
            this.dgv_busquedaProd.TabIndex = 6;
            this.dgv_busquedaProd.TabStop = false;
            this.dgv_busquedaProd.Visible = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 2;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_agregar.Location = new System.Drawing.Point(13, 202);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(341, 37);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pb_buscar
            // 
            this.pb_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_buscar.Image = global::Proyecto_Final_Lab_I.Properties.Resources.image1;
            this.pb_buscar.Location = new System.Drawing.Point(322, 264);
            this.pb_buscar.Name = "pb_buscar";
            this.pb_buscar.Size = new System.Drawing.Size(39, 29);
            this.pb_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_buscar.TabIndex = 12;
            this.pb_buscar.TabStop = false;
            this.pb_buscar.Click += new System.EventHandler(this.pb_buscar_Click);
            // 
            // dgv_detalleFactura
            // 
            this.dgv_detalleFactura.AllowUserToResizeColumns = false;
            this.dgv_detalleFactura.AllowUserToResizeRows = false;
            this.dgv_detalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_detalleFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgv_detalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detalleFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_detalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_detalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalleFactura.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_detalleFactura.EnableHeadersVisualStyles = false;
            this.dgv_detalleFactura.GridColor = System.Drawing.Color.LightGreen;
            this.dgv_detalleFactura.Location = new System.Drawing.Point(454, 87);
            this.dgv_detalleFactura.Name = "dgv_detalleFactura";
            this.dgv_detalleFactura.ReadOnly = true;
            this.dgv_detalleFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_detalleFactura.RowHeadersVisible = false;
            this.dgv_detalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_detalleFactura.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_detalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalleFactura.Size = new System.Drawing.Size(565, 422);
            this.dgv_detalleFactura.TabIndex = 13;
            this.dgv_detalleFactura.TabStop = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_total.Location = new System.Drawing.Point(449, 532);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(146, 25);
            this.lbl_total.TabIndex = 15;
            this.lbl_total.Text = "TOTAL $ 0,00";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_fecha.Location = new System.Drawing.Point(969, 4);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 20);
            this.lbl_fecha.TabIndex = 17;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_hora.Location = new System.Drawing.Point(892, 4);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(26, 20);
            this.lbl_hora.TabIndex = 16;
            this.lbl_hora.Text = "Hr";
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // lbl_numFac
            // 
            this.lbl_numFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbl_numFac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_numFac.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_numFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numFac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_numFac.Location = new System.Drawing.Point(464, 66);
            this.lbl_numFac.Name = "lbl_numFac";
            this.lbl_numFac.Size = new System.Drawing.Size(85, 15);
            this.lbl_numFac.TabIndex = 18;
            this.lbl_numFac.TabStop = false;
            this.lbl_numFac.Text = "N° Factura";
            // 
            // lbl_numFacStr
            // 
            this.lbl_numFacStr.AutoSize = true;
            this.lbl_numFacStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numFacStr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_numFacStr.Location = new System.Drawing.Point(541, 66);
            this.lbl_numFacStr.Name = "lbl_numFacStr";
            this.lbl_numFacStr.Size = new System.Drawing.Size(16, 16);
            this.lbl_numFacStr.TabIndex = 19;
            this.lbl_numFacStr.Text = "0";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.dgv_detalleFactura);
            this.Controls.Add(this.lbl_numFacStr);
            this.Controls.Add(this.lbl_numFac);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.pb_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.bnt_cancelar);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_busquedaProd);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_titulo_venta);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busquedaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_venta;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button bnt_cancelar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pb_buscar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DataGridView dgv_busquedaProd;
        private System.Windows.Forms.Button btn_agregar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private System.Windows.Forms.DataGridView dgv_detalleFactura;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.TextBox lbl_numFac;
        private System.Windows.Forms.Label lbl_numFacStr;
    }
}