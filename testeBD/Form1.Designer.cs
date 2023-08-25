namespace testeBD
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
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label3 = new Label();
            btnsalvar = new Button();
            ltContato = new ListView();
            txtBuscar = new TextBox();
            label5 = new Label();
            label2 = new Label();
            bntBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(31, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(31, 198);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(192, 27);
            txtTelefone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 175);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Telefone:";
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(129, 236);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(94, 29);
            btnsalvar.TabIndex = 6;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnCadastrar_Click;
            // 
            // ltContato
            // 
            ltContato.Location = new Point(268, 135);
            ltContato.Name = "ltContato";
            ltContato.Size = new Size(474, 130);
            ltContato.TabIndex = 7;
            ltContato.UseCompatibleStateImageBehavior = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(267, 102);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(384, 27);
            txtBuscar.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 112);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 76);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 11;
            label2.Text = "Buscar Contato:";
            // 
            // bntBuscar
            // 
            bntBuscar.Location = new Point(668, 101);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(74, 29);
            bntBuscar.TabIndex = 12;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 348);
            Controls.Add(bntBuscar);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(ltContato);
            Controls.Add(btnsalvar);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label3;
        private Button btnsalvar;
        private ListView ltContato;
        private TextBox txtBuscar;
        private Label label5;
        private Label label2;
        private Button bntBuscar;
    }
}