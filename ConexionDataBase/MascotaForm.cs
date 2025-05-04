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

    public partial class TxtRunM : Form
    {
        VetdbContext db = new VetdbContext();
        public TxtRunM()
        {
            InitializeComponent();
            CargarRun();
        }

        public void CargarRun()
        {
            var Run = db.Clientes.ToList();
            cbRunM.DataSource = Run;

            cbRunM.ValueMember = "Run";
            cbRunM.DisplayMember = "Run";

            cbRunM.SelectedIndex = -1;
        }
        Helper h = new Helper();


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string error = "";
            if (TxtNombre.Text.Trim() == "")
                error += "debe ingrear nombre\n";
            if (TxtEspecie.Text == "")
                error += "debe ingresar especie\n";
            if (TxtSexo.Text == "")
                error += "debe ingresar sexo\n";
           
            if (error != "")
                MessageBox.Show(error, "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            {
                //instancia la clase de la database
                Mascotum m = new Mascotum();
                m.Nombre = TxtNombre.Text;
                m.Especie = TxtEspecie.Text;
                m.Raza = TxtRaza.Text;
                m.Sexo = TxtSexo.Text;
                m.Edad = int.Parse(TxtEdad.Text);
                m.Run = cbRunM.Text;

                db.Mascota.Add(m);
                db.SaveChanges();
                MessageBox.Show("el cliente ha sido guardado con exito", "exito");
                Limpiar();
            }
            
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.soloNumeros(e);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {  
            Limpiar();
            //agregar que solo se borre el error que aparece  
        }
        public void Limpiar()
        {
            TxtEdad.Clear();
            TxtNombre.Clear();
            TxtRaza.Clear();
            TxtEspecie.Clear();
            TxtSexo.Clear();
            cbRunM.SelectedIndex = -1;
             
        }
    }
}
