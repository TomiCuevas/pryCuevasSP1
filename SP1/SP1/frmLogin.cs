using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" && txtContrasenia.Text == "adm135$") ||
                (txtUsuario.Text == "Operador" && txtContrasenia.Text == "ope246$"))
            {
                this.Hide(); 
                frmInicio f = new frmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show(); 
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                intentos++; 
                if (intentos == 3) 
                {
                    this.Close();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtContrasenia.Enabled = false;
            }
            else
            {
                txtContrasenia.Enabled = true;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }
    }
}
