namespace ConexionDataBase
{
    partial class ClienteForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TxtRun = new TextBox();
            label2 = new Label();
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtTelefono = new TextBox();
            TxtDireccion = new TextBox();
            BtnAgregar = new Button();
            BtnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 83);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Cliente";
            // 
            // TxtRun
            // 
            TxtRun.Location = new Point(143, 150);
            TxtRun.Name = "TxtRun";
            TxtRun.Size = new Size(100, 23);
            TxtRun.TabIndex = 1;
            TxtRun.Leave += TxtRun_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 158);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "run";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(143, 191);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 3;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(143, 232);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(100, 23);
            TxtApellido.TabIndex = 4;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(143, 277);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 199);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 240);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 285);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 324);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 362);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 10;
            label7.Text = "direccion";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(143, 316);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(100, 23);
            TxtTelefono.TabIndex = 11;
            TxtTelefono.KeyPress += TxtTelefono_KeyPress;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(143, 354);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(100, 23);
            TxtDireccion.TabIndex = 12;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(339, 149);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 13;
            BtnAgregar.Text = "agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(339, 194);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 14;
            BtnLimpiar.Text = "limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // ClienteForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtDireccion);
            Controls.Add(TxtTelefono);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtEmail);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(TxtRun);
            Controls.Add(label1);
            Name = "ClienteForms";
            Text = "ClienteForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtRun;
        private Label label2;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtTelefono;
        private TextBox TxtDireccion;
        private Button BtnAgregar;
        private Button BtnLimpiar;
    }
}