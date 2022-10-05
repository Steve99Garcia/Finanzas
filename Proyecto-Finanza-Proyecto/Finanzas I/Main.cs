using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Finanzas_I.Poco;

namespace Finanzas_I
{
    public partial class Main : Form
    {
        Datos Informacion;
        public Main()
        {
            InitializeComponent();
            Informacion = new Datos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRazonesFinancieras_Click(object sender, EventArgs e)
        {
            if (!SubMenuRazones.Visible)
            {
                SubMenuRazones.Visible = true;
            }
            else
            {
                SubMenuRazones.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubMenuRazones.Visible = false;
            if (Informacion.Activos == 0)
            {
                MessageBox.Show("No has ingresado ningún dato para realizar estas operaciones!!", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                OpenForm(new Liquidez());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubMenuRazones.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubMenuRazones.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubMenuRazones.Visible = false;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenForm(Object FormHija)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Form FH = FormHija as Form;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(FH);
            FH.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenForm(new Inicio());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenForm(new Inicio());
        }

        private void BtnBalanceGeneral_Click(object sender, EventArgs e)
        {
            OpenForm(new BalanceGeneral());
        }
    }
}