using Entidad.Seguridad;
using System;
using System.Data;
using System.Windows.Forms;
using Vista.General;

namespace Vista.Seguridad
{
    public partial class UsuarioUI : Form
    {
        Usuario usuario = new Usuario();
        public UsuarioUI()
        {
            InitializeComponent();
        }
        private void UsuarioUI_Load(object sender, EventArgs e)
        {
            GeneralUI.colocarIconosMenu(tstMenuPatron);
            GeneralUI.posCargadoForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            GeneralUI.formNuevo(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tstModificar_Click(object sender, EventArgs e)
        {
            GeneralUI.fnModificarForm(this, tstMenuPatron, tsbGuardar, tsbCancelar);
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            GeneralUI.fnCancelarForm(this, tstMenuPatron, tsbNuevo, tsbBuscar);
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            /*if (validarForm() && MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usuario.idUsuario = (txtBCodigo.Text.Equals(String.Empty) ? 0 : int.Parse(txtBCodigo.Text));
                usuario.nombre = txtNombre.Text;
                usuario.usuario = txtUsuario.Text;
                usuario.pass = txtClave.Text;
                try
                {
                    UsuarioDAL.guardar(usuario);
                    GeneralC.posGuardar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular, null, Mensajes.CONFIRMACION_GUARDADO);
                    txtBCodigo.Text = usuario.idUsuario.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<string> columnasOcultar = new List<string>();
                columnasOcultar.Add("Clave");
                columnasOcultar.Add("IdRol");
                columnasOcultar.Add("Rol");
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Sentencias.USUARIO_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarUsuario),
                                            Mensajes.BUSQUEDA_USUARIOS,
                                            true,
                                            columnasOcultar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        private void tsbAnular_Click(object sender, EventArgs e)
        {
            /*if (usuario.idUsuario == 1)
            {
                MessageBox.Show("No se puede eliminar el usuario administrador!", Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        UsuarioDAL.anular(usuario);
                        GeneralC.posAnular(this, tstMenuPatron, tsbNuevo, tsbBuscar, Mensajes.CONFIRMACION_ANULADO);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }*/

        }
        private void tsbBuscarRol_Click(object sender, EventArgs e)
        {
           /* try
            {
                List<string> parametros = new List<string>();
                parametros.Add("");
                GeneralC.buscarDevuelveFila(Sentencias.ROL_BUSCAR,
                                            parametros,
                                            new GeneralC.cargarInfoFila(cargarRol),
                                            Mensajes.BUSQUEDA_ROL,
                                            true,
                                            null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Mensajes.NOMBRE_SOFT, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        void cargarRol(DataRow fila)
        {
            usuario.idRol = fila.Field<int>("Código");
            txtBRol.Text = fila.Field<string>("Descripción");
        }
        void cargarUsuario(DataRow fila)
        {
            usuario.idUsuario = fila.Field<int>("Código");
            txtBCodigo.Text = fila.Field<int>("Código").ToString();
            txtNombre.Text = fila.Field<string>("Nombre");
            txtUsuario.Text = fila.Field<string>("Usuario");
            txtClave.Text = fila.Field<string>("Clave");
            txtBRol.Text = fila.Field<string>("Rol");
            usuario.idRol = fila.Field<int>("IdRol");
            GeneralUI.posBuscar(this, tstMenuPatron, tsbNuevo, tsbBuscar, tstModificar, tsbAnular);
        }
        private bool validarForm()
        {
            if (txtNombre.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe ingresar el nombre del usuario !", txtNombre);
                return false;
            }
            else if (txtUsuario.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe ingresar el usuario !", txtUsuario);
                return false;
            }
            else if (txtClave.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe ingresar la clave !", txtClave);
                return false;
            }
            else if (txtBRol.Text.Equals(""))
            {
                GeneralUI.mostrarMensajeInformacio("Debe escojer el rol para el usuario !", txtBRol);
                return false;
            }
            else
            {
                return true;
            }

        }       
    }
}
