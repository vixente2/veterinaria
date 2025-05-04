namespace ConexionDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCliente = new Button();
            BtnUsuario = new Button();
            BtnMascota = new Button();
            BtnAtencion = new Button();
            SuspendLayout();
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(286, 66);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(165, 69);
            BtnCliente.TabIndex = 0;
            BtnCliente.Text = "Cliente";
            BtnCliente.UseVisualStyleBackColor = true;
            BtnCliente.Click += BtnCliente_Click;
            // 
            // BtnUsuario
            // 
            BtnUsuario.Location = new Point(286, 141);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(165, 69);
            BtnUsuario.TabIndex = 1;
            BtnUsuario.Text = "Usuario";
            BtnUsuario.UseVisualStyleBackColor = true;
            BtnUsuario.Click += BtnUsuario_Click;
            // 
            // BtnMascota
            // 
            BtnMascota.Location = new Point(286, 216);
            BtnMascota.Name = "BtnMascota";
            BtnMascota.Size = new Size(165, 69);
            BtnMascota.TabIndex = 2;
            BtnMascota.Text = "Mascota";
            BtnMascota.UseVisualStyleBackColor = true;
            BtnMascota.Click += BtnMascota_Click;
            // 
            // BtnAtencion
            // 
            BtnAtencion.Location = new Point(286, 291);
            BtnAtencion.Name = "BtnAtencion";
            BtnAtencion.Size = new Size(165, 69);
            BtnAtencion.TabIndex = 3;
            BtnAtencion.Text = "Atencion";
            BtnAtencion.UseVisualStyleBackColor = true;
            BtnAtencion.Click += BtnAtencion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAtencion);
            Controls.Add(BtnMascota);
            Controls.Add(BtnUsuario);
            Controls.Add(BtnCliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCliente;
        private Button BtnUsuario;
        private Button BtnMascota;
        private Button BtnAtencion;
    }
}
