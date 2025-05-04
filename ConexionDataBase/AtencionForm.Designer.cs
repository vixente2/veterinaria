namespace ConexionDataBase
{
    partial class AtencionForm
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
            DtFecha = new DateTimePicker();
            TxtValor = new TextBox();
            TxtObservacion = new TextBox();
            CbUsuario = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnAgregar = new Button();
            BtnLimpiar = new Button();
            SuspendLayout();
            // 
            // DtFecha
            // 
            DtFecha.Location = new Point(288, 154);
            DtFecha.Name = "DtFecha";
            DtFecha.Size = new Size(200, 23);
            DtFecha.TabIndex = 0;
            // 
            // TxtValor
            // 
            TxtValor.Location = new Point(288, 243);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(200, 23);
            TxtValor.TabIndex = 2;
            // 
            // TxtObservacion
            // 
            TxtObservacion.Location = new Point(288, 286);
            TxtObservacion.Name = "TxtObservacion";
            TxtObservacion.Size = new Size(200, 23);
            TxtObservacion.TabIndex = 3;
            // 
            // CbUsuario
            // 
            CbUsuario.FormattingEnabled = true;
            CbUsuario.Location = new Point(288, 198);
            CbUsuario.Name = "CbUsuario";
            CbUsuario.Size = new Size(200, 23);
            CbUsuario.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 160);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 201);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 246);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 289);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "observacion";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(573, 193);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(573, 262);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 10;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // AtencionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnAgregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CbUsuario);
            Controls.Add(TxtObservacion);
            Controls.Add(TxtValor);
            Controls.Add(DtFecha);
            Name = "AtencionForm";
            Text = "AtencionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtFecha;
        private TextBox TxtValor;
        private TextBox TxtObservacion;
        private ComboBox CbUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAgregar;
        private Button BtnLimpiar;
    }
}