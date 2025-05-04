using ConexionDataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDataBase
{
    public partial class AtencionForm : Form
    {
        public AtencionForm()
        {
            InitializeComponent();
            CargarUsuario();
        }
        VetdbContext db = new VetdbContext();
        
        public void CargarUsuario()
        {
            var Usuario = db.Usuarios.ToList();
            CbUsuario.DataSource = Usuario;

            CbUsuario.ValueMember = "iduser";
            CbUsuario.DisplayMember = "nombre";

            CbUsuario.SelectedIndex = -1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string error = "";
            if (CbUsuario.SelectedIndex == -1)
                error += "debe ingresar usuario \n";

            if (TxtValor.Text == "")
                error += "debe ingresar valor \n";
        
            if (TxtObservacion.Text == "" )
                error += "debe ingresar observacion \n";
            if (error != "")
                MessageBox.Show(error, "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
                Atencion a = new Atencion();
                a.Fecha =  DateTime.Parse(DtFecha.Text);
                a.IdUser = int.Parse(CbUsuario.SelectedValue.ToString());
                a.Valor = int.Parse(TxtValor.Text);
                a.Observacion = TxtObservacion.Text;

                db.Atencions.Add(a);
                db.SaveChanges();
                MessageBox.Show("el cliente ha sido guardado con exito", "exito");
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            


        }

        
    }
}
