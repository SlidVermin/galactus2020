using Modelo.General;
using Modelo.Negocio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Vista.General;

namespace Vista
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(200, 107, 107, 107);
            lblUsuario.BackColor = Color.Transparent;
            lblContrasena.BackColor = Color.Transparent;
            lbSede.BackColor = Color.Transparent;
            btIngresar.BackColor = Color.FromArgb(180, 131, 173, 210);
            btSalir.BackColor = Color.FromArgb(180, 131, 173, 210);
        }

        private bool validarCamposObligatorios() {
            if (txtUsuario.Text != String.Empty || txtContrasena.Text != String.Empty)
            {
                return true;
            }

            return false;
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (!validarCamposObligatorios()) 
            {
                MessageBox.Show("los campos marcados son obligatorios", "", MessageBoxButtons.OK);
            }
            else
            {
                if (LoginBL.esAutenticacionValida(txtUsuario.Text, txtContrasena.Text))
                {
                    SesionBL.iniciarSesion(UsuarioActual.IdUsuario);
                    mostrarFormularioPrincipal();
                }
                else
                {
                    /*TODO
                 Mostrar mensaje usuario invalido    
                 */
                }
            }            
        }

        public void mostrarFormularioPrincipal()
        {
            PrincipalUI principalUI = new PrincipalUI();
            principalUI.Show();
            this.Hide();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
