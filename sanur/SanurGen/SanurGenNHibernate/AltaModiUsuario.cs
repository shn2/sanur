using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.Enumerated.Sanur;
using SanurGenNHibernate.CEN.Sanur;

namespace SanurGenNHibernate
{
    public partial class AltaModiUsuario : Form
    {
        public AltaModiUsuario()
        {
            InitializeComponent();
        }

        private void alta_Click(object sender, EventArgs e)
        {
            //UsuarioEN usuario = new UsuarioEN();
            UsuarioCEN usuarioCEN = new UsuarioCEN();
            MedicoCEN medicoCEN = new MedicoCEN();
            AdministradorCEN administradorCEN = new AdministradorCEN();
            AdministrativoCEN administrativoCEN = new AdministrativoCEN();


            string mensaje = "¿Seguro de que desea crear un nuevo usuario con estos datos?";
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            string leyenda = "Crear usuario";
            DialogResult resultado;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            resultado = MessageBox.Show(mensaje,leyenda,opciones,icono);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //usuarioCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString());

                if (Tipo.Text.ToString() == "Medico")
                    medicoCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString(), obtenerEspecialidad());
                else if (Tipo.Text.ToString() == "Administrativo")
                    administrativoCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString());
                else//si es administrador
                    administradorCEN.New_(nombre.Text.ToString(), contrasena.Text.ToString(), false, email.Text.ToString(), apellidos.Text.ToString());
                
                
                MessageBox.Show("usuario creado correctamente");
                Close();
            }
            else
                Close();

        }

        private void Tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Tipo.Text.ToString() == "Medico")
            {
                especialidad.Visible = true;
                label6.Visible = true;
            }
            else
            {
                especialidad.Visible = false;
                label6.Visible = false;
            }
        }

        private EspecialidadEnum obtenerEspecialidad()
        {
            if (especialidad.Text.ToString() == "Ginecología")
                return EspecialidadEnum.ginecologia;
            else if (especialidad.Text.ToString() == "Traumatología")
                return EspecialidadEnum.traumatologia;
            else if (especialidad.Text.ToString() == "Pediatría")
                return EspecialidadEnum.pediatria;
            else if (especialidad.Text.ToString() == "Psiquiatría")
                return EspecialidadEnum.psiquiatria;
            else
                return EspecialidadEnum.interna;
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            MedicoCEN medicoCEN = new MedicoCEN();
            
        }
    }
}
