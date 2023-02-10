using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public Inicio(Usuario objUsuario)
        {
            usuarioActual = objUsuario;
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.nombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.FromArgb(8, 83, 150);
                menuActivo.ForeColor = Color.FromArgb(224, 224, 224);
            }
            menu.BackColor = Color.FromArgb(178, 214, 243);
            menu.ForeColor = Color.FromArgb(8, 83, 150);
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(63, 61, 64);
            contenedor.Controls.Add(formulario);
            formulario.Show();

        }
       

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new frmProducto());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmVentas());
        }

        private void subMenuDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmDetalleVenta());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new frmCompras());
        }

        private void subMenuDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new frmDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }
    }
}
