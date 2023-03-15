namespace PizzariaDoZe.Telas
{
    partial class CadastroDeClientesForm
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
            labelNome = new Label();
            labelEmail = new Label();
            labelCpf = new Label();
            labelTelefone = new Label();
            labelRua = new Label();
            labelBairro = new Label();
            labelComplemento = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtRua = new TextBox();
            txtComplemento = new TextBox();
            txtTelefone = new TextBox();
            txtBairro = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(36, 26);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(36, 62);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(36, 98);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(28, 15);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(229, 26);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Location = new Point(37, 140);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(27, 15);
            labelRua.TabIndex = 4;
            labelRua.Text = "Rua";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(229, 62);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 5;
            labelBairro.Text = "Bairro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(36, 178);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 6;
            labelComplemento.Text = "Complemento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(141, 23);
            txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(82, 95);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(141, 23);
            txtCpf.TabIndex = 9;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(82, 137);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(141, 23);
            txtRua.TabIndex = 10;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(126, 175);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(154, 23);
            txtComplemento.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(286, 23);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(141, 23);
            txtTelefone.TabIndex = 12;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(286, 59);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(141, 23);
            txtBairro.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(37, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 57);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(285, 235);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(109, 57);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(161, 235);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(109, 57);
            btnLimpar.TabIndex = 31;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // CadastroDeClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(443, 316);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtBairro);
            Controls.Add(txtTelefone);
            Controls.Add(txtComplemento);
            Controls.Add(txtRua);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(labelComplemento);
            Controls.Add(labelBairro);
            Controls.Add(labelRua);
            Controls.Add(labelTelefone);
            Controls.Add(labelCpf);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Name = "CadastroDeClientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeClientesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelEmail;
        private Label labelCpf;
        private Label labelTelefone;
        private Label labelRua;
        private Label labelBairro;
        private Label labelComplemento;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtRua;
        private TextBox txtComplemento;
        private TextBox txtTelefone;
        private TextBox txtBairro;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}