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

namespace ConexionDataBase
{
    public partial class ClienteForms : Form
    {
        //instanciar el contexto de datos para conectar la base de datos
        VetdbContext db = new VetdbContext();
        public ClienteForms()
        {
            InitializeComponent();
        }
        //instanciar biblioteca helpers
        Helper h = new Helper();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string error = "";
            //validar todos los campos contra espacios vacios 
            if (TxtRun.Text.Trim() == "")
                error = "debe ingresar run \n";
            if (TxtNombre.Text.Trim() == "")
                error += "debe ingresar nombre \n";
            if (TxtApellido.Text.Trim() == "")
                error += "debe ingresar apellido \n";
            if (TxtEmail.Text.Trim() == "")
                error += "debe ingresar email \n";
            else

                if (!h.ValidarEmail(TxtEmail.Text))
                error += "el email no tiene el formato correcto \n";

            if (TxtTelefono.Text.Trim() == "")
                error += "debe ingresar telefono \n";
            if (TxtDireccion.Text.Trim() == "")
                error += "debe ingresar Direccion \n";
            if (error != "")
                MessageBox.Show(error, "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //imstamciar una clase cliente 
                Cliente c = new Cliente();
                c.Run = TxtRun.Text;
                c.Nombre = TxtNombre.Text;
                c.Apellido = TxtApellido.Text;
                c.Email = TxtEmail.Text;
                c.Direccion = TxtDireccion.Text;
                c.Fono = int.Parse(TxtTelefono.Text);
                //guardamos en la base de datos del cliente
                db.Clientes.Add(c); //insert into
                //guarda los cambios en la base de datos
                db.SaveChanges();
                MessageBox.Show("el cliente ha sido guardado con exito", "exito");
                limpiar();
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.soloNumeros(e);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtRun.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();
            TxtTelefono.Clear();
        }
        public bool VerificarRun(string run)
        {
            Cliente c = db.Clientes.FirstOrDefault(x => x.Run == run);
            if (c != null)
                return true;
            return false;

        }

        private void TxtRun_Leave(object sender, EventArgs e)
        {
            if (VerificarRun(TxtRun.Text))
            {
                MessageBox.Show("el run ya esta registrado", "error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRun.Clear();
            }
        }
    }
}
