using ConexionDataBase.Models;

namespace ConexionDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
     
        ClienteForms CF = new ClienteForms();
        UsuariosForm UF = new UsuariosForm();
        AtencionForm AF = new AtencionForm();
        TxtRunM MF = new TxtRunM();

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            CF.Show();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            UF.Show();
        }

        private void BtnMascota_Click(object sender, EventArgs e)
        {
          MF.Show();
        }

        private void BtnAtencion_Click(object sender, EventArgs e)
        {
            AF.Show();
        }
    }

    
}
