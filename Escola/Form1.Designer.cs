namespace Escola
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
            btnConexao = new Button();
            Id = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            Nome = new Label();
            Email = new Label();
            Telefone = new Label();
            BtnCadastrar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(662, 41);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(75, 23);
            btnConexao.TabIndex = 0;
            btnConexao.Text = "Conexão";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += btnConexao_Click;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(75, 162);
            Id.Name = "Id";
            Id.Size = new Size(17, 15);
            Id.TabIndex = 1;
            Id.Text = "Id";
            Id.Click += Id_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(160, 154);
            txtId.Name = "txtId";
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(160, 203);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(160, 296);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(148, 23);
            txtTelefone.TabIndex = 5;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(73, 212);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 6;
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(75, 257);
            Email.Name = "Email";
            Email.Size = new Size(41, 15);
            Email.TabIndex = 7;
            Email.Text = "E-mail";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(75, 304);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(52, 15);
            Telefone.TabIndex = 8;
            Telefone.Text = "Telefone";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(245, 364);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 9;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(365, 364);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(93, 29);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(BtnCadastrar);
            Controls.Add(Telefone);
            Controls.Add(Email);
            Controls.Add(Nome);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(Id);
            Controls.Add(btnConexao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConexao;
        private Label Id;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label Nome;
        private Label Email;
        private Label Telefone;
        private Button BtnCadastrar;
        private Button btnExcluir;
    }
}
