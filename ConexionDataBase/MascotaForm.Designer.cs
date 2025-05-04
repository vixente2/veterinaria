namespace ConexionDataBase
{
    partial class TxtRunM
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
            BtnLimpiar = new Button();
            BtnAgregar = new Button();
            TxtEdad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtSexo = new TextBox();
            TxtRaza = new TextBox();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtEspecie = new TextBox();
            label1 = new Label();
            cbRunM = new ComboBox();
            SuspendLayout();
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(494, 189);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 29;
            BtnLimpiar.Text = "limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(494, 144);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 28;
            BtnAgregar.Text = "agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // TxtEdad
            // 
            TxtEdad.Location = new Point(298, 311);
            TxtEdad.Name = "TxtEdad";
            TxtEdad.Size = new Size(100, 23);
            TxtEdad.TabIndex = 26;
            TxtEdad.KeyPress += TxtEdad_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(267, 352);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 25;
            label7.Text = "run";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 314);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 24;
            label6.Text = "edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 275);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 23;
            label5.Text = "sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 230);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 22;
            label4.Text = "raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 152);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 21;
            label3.Text = "nombre";
            // 
            // TxtSexo
            // 
            TxtSexo.Location = new Point(298, 272);
            TxtSexo.Name = "TxtSexo";
            TxtSexo.Size = new Size(100, 23);
            TxtSexo.TabIndex = 20;
            // 
            // TxtRaza
            // 
            TxtRaza.Location = new Point(298, 227);
            TxtRaza.Name = "TxtRaza";
            TxtRaza.Size = new Size(100, 23);
            TxtRaza.TabIndex = 19;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(298, 148);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 193);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 17;
            label2.Text = "especie";
            // 
            // TxtEspecie
            // 
            TxtEspecie.Location = new Point(298, 189);
            TxtEspecie.Name = "TxtEspecie";
            TxtEspecie.Size = new Size(100, 23);
            TxtEspecie.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 78);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 15;
            label1.Text = "Formulario de Mascota";
            // 
            // cbRunM
            // 
            cbRunM.FormattingEnabled = true;
            cbRunM.Location = new Point(298, 349);
            cbRunM.Name = "cbRunM";
            cbRunM.Size = new Size(121, 23);
            cbRunM.TabIndex = 30;
            // 
            // TxtRunM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbRunM);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtEdad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtSexo);
            Controls.Add(TxtRaza);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(TxtEspecie);
            Controls.Add(label1);
            Name = "TxtRunM";
            Text = "MascotaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLimpiar;
        private Button BtnAgregar;
        private TextBox TxtEdad;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtSexo;
        private TextBox TxtRaza;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtEspecie;
        private Label label1;
        private ComboBox cbRunM;
    }
}