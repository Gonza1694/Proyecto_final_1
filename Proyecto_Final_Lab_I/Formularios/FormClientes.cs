﻿using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            CargarGrilla();
            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            dgv_listaClientes.Columns["CtaCte"].Visible = false;

            dgv_listaClientes.Columns["LimiteDeCompra"].Visible = false;

            dgv_listaClientes.Columns["Monto"].Visible = false;

            dgv_listaClientes.Columns["MontoStr"].HeaderText = "Monto";

            
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, System.EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
        }

        private void CargarGrilla()
        {
            dgv_listaClientes.DataSource = Program.Clientes.OrderBy(x => x.Apellido).ToList();
        }
    }
}