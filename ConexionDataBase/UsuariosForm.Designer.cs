namespace ConexionDataBase
{
    partial class UsuariosForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnagregar = new Button();
            cbRunM = new Button();
            TxtNombre = new TextBox();
            TxtContrasena = new TextBox();
            TxtEmail = new TextBox();
            cbRol = new ComboBox();
            label6 = new Label();
            TxtReContrasena = new TextBox();
            dvUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 84);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "formulario cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 174);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 203);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 232);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 9;
            label4.Text = "contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 148);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 10;
            label5.Text = "rol";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(392, 170);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 11;
            btnagregar.Text = "agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // cbRunM
            // 
            cbRunM.Location = new Point(392, 224);
            cbRunM.Name = "cbRunM";
            cbRunM.Size = new Size(75, 23);
            cbRunM.TabIndex = 12;
            cbRunM.Text = "limpiar";
            cbRunM.UseVisualStyleBackColor = true;
            cbRunM.Click += btnlimpiar_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(213, 174);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 4;
            // 
            // TxtContrasena
            // 
            TxtContrasena.Location = new Point(213, 229);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.PasswordChar = '*';
            TxtContrasena.Size = new Size(100, 23);
            TxtContrasena.TabIndex = 3;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(213, 200);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 2;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(213, 145);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(121, 23);
            cbRol.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 260);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 14;
            label6.Text = "repetir";
            // 
            // TxtReContrasena
            // 
            TxtReContrasena.Location = new Point(213, 260);
            TxtReContrasena.Name = "TxtReContrasena";
            TxtReContrasena.Size = new Size(100, 23);
            TxtReContrasena.TabIndex = 15;
            // 
            // dvUser
            // 
            dvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvUser.Location = new Point(655, 117);
            dvUser.Name = "dvUser";
            dvUser.Size = new Size(240, 150);
            dvUser.TabIndex = 16;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 450);
            Controls.Add(dvUser);
            Controls.Add(TxtReContrasena);
            Controls.Add(label6);
            Controls.Add(cbRol);
            Controls.Add(cbRunM);
            Controls.Add(btnagregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtNombre);
            Controls.Add(TxtContrasena);
            Controls.Add(TxtEmail);
            Controls.Add(label1);
            Name = "UsuariosForm";
            Text = "UsuariosForm";
            ((System.ComponentModel.ISupportInitialize)dvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnagregar;
        private Button btnlimpiar;
        private TextBox TxtNombre;
        private TextBox TxtContrasena;
        private TextBox TxtEmail;
        private ComboBox cbRol;
        private Label label6;
        private TextBox TxtReContrasena;
        private DataGridView dvUser;
        private Button cbRunM;
    }
}