using Proyecto_Final_Lab_I.Clases;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            CargarGrillaProductos();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProveedor();
        }

        private void AgregarProveedor()
        {
            Proveedor Proveedores = new Proveedor()
            {
                RazonSocial = txt_razonSocial.Text,
                CUIT = txt_cuit.Text,
                Localidad = txt_Localidad.Text,
                Direccion = txt_domicilio.Text,
                Telefono = txt_telefono.Text,
                Email = txt_mail.Text
            };
            Program.Proveedores.Add(Proveedores);
            //ReinciarPanel();
            CargarGrillaProductos();
        }

        private void CargarGrillaProductos()
        {
            dgv_listaProveedores.DataSource = Program.Proveedores.OrderBy(x => x.RazonSocial).ToList();
        }

        private void ReinciarPanel()
        {
            throw new NotImplementedException();
        }
    }
}