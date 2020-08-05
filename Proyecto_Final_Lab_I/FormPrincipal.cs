using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Final_Lab_I
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Funcionalidades del Form

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

        private void button7_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //pivate void AbrirForm<MiForm>() where MiForm : Form new()
        //{
        //    Form formulario;
        //    formulario = flp
        //}
    }
}
