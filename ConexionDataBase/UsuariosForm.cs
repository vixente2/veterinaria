using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDataBase.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConexionDataBase
{
    public partial class UsuariosForm : Form
    {

        VetdbContext db = new VetdbContext();
        public UsuariosForm()
        {
            InitializeComponent();
            CargarRol();
            CargarUsuarios();
        }



        public void CargarRol()
        {
            var roles = db.Rols.ToList();
            cbRol.DataSource = roles;

            cbRol.ValueMember = "IdRol";
            cbRol.DisplayMember = "Rol1";

            cbRol.SelectedIndex = -1;
        }
        Helper h = new Helper();
        private void btnagregar_Click(object sender, EventArgs e)
        {
            string error = "";
            if (cbRol.SelectedIndex == -1)
                error += "debe ingresar un rol \n";
            if (TxtNombre.Text.Trim() == "")
                error += "debe ingresar nombre \n";
            if (TxtEmail.Text.Trim() == "")
                error += "debe ingresar email \n";
            else

                if (!h.ValidarEmail(TxtEmail.Text))
                error += "el email no tiene el formato correcto \n";

            if (TxtContrasena.Text.Trim() == "")
                error += "debe ingresar contraseña \n";
            else
            if (TxtContrasena.Text != TxtReContrasena.Text)
                error += "las contraseña no coinciden";



            if (error != "")
                MessageBox.Show(error, "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
               Usuario u = new Usuario();
                u.IdRol = int.Parse(cbRol.SelectedValue.ToString());
                u.Nombre = TxtNombre.Text;
                u.Email = TxtEmail.Text;    
                u.Password = TxtContrasena.Text;
                db.Usuarios.Add(u);
                db.SaveChanges();
                MessageBox.Show("el cliente ha sido guardado con exito", "exito");
                Limpiar();
                CargarUsuarios();

            }

        }
        public void Limpiar()
        {
            cbRol.SelectedIndex = -1;
            TxtContrasena.Text = "";
            TxtReContrasena.Text = "";
            TxtEmail.Text = "";
            TxtNombre.Text = "";


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void CargarUsuarios()
        {
            var usuarios = (from u in db.Usuarios select new
            {
                u.IdUser,
                u.Email,
                u.Nombre,
                u.Password,
                Rol = u.IdRolNavigation.Rol1,
                u.IdRol
            }).ToList();

            dvUser.DataSource = usuarios;
            dvUser.Columns[0].Visible = false;
            dvUser.Columns[3].Visible = false;
            dvUser.Columns[5].Visible = false;
        }
    }
}
