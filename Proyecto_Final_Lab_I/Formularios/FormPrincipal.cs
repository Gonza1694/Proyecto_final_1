using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto_Final_Lab_I
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //#region Funcionalidades del Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //DESPLAZAR FORMULARIO
        private void flp_barra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            AbrirForm<FormVentas>();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirForm<FormProductos>();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirForm<FormClientes>();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirForm<FormProveedores>();
        }

        private void btn_Ctacte_Click(object sender, EventArgs e)
        {
            AbrirForm<FormCuenta_Cte>();
        }

        //Abrir formulario dentro del panel
        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = flp_contenedor.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion el form

            if (formulario == null) // Si formulario no existe
            {
                formulario = new MiForm(); //Se crea una nueva instancia
                formulario.TopLevel = false; //No es un formulario de nivel superior
                formulario.Dock = DockStyle.Fill;
                flp_contenedor.Controls.Add(formulario);//Agregamos el formulario a la coleccion de control del panel
                flp_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else // Si el formulario existe, se lo trae al frente
            {
                formulario.BringToFront();
            }
        }
    }
}