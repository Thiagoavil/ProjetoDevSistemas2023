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
            txtRua = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            panel1 = new Panel();
            labelCliente = new Label();
            panel2 = new Panel();
            labelCep = new Label();
            txtCEP = new TextBox();
            txtLogradouro = new TextBox();
            labelLogradouro = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(26, 60);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            labelNome.Click += labelNome_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(26, 108);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(26, 156);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 20);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF";
            labelCpf.Click += labelCpf_Click;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(14, 205);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(66, 20);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone";
            labelTelefone.Click += labelTelefone_Click;
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Location = new Point(60, 173);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(34, 20);
            labelRua.TabIndex = 4;
            labelRua.Text = "Rua";
            labelRua.Click += labelRua_Click;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(58, 208);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 5;
            labelBairro.Text = "Bairro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(9, 128);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 6;
            labelComplemento.Text = "Complemento";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(79, 56);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 27);
            txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 104);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(112, 169);
            txtRua.Margin = new Padding(3, 4, 3, 4);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(161, 27);
            txtRua.TabIndex = 12;
            txtRua.TextChanged += txtRua_TextChanged;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(112, 124);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(175, 27);
            txtComplemento.TabIndex = 13;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(123, 204);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(161, 27);
            txtBairro.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(42, 313);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 76);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(326, 313);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 76);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(184, 313);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 76);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(78, 153);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(161, 27);
            maskedTextBoxCpf.TabIndex = 11;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(79, 202);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(161, 27);
            maskedTextBoxTelefone.TabIndex = 8;
            maskedTextBoxTelefone.MaskInputRejected += maskedTextBoxTelefone_MaskInputRejected;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCliente);
            panel1.Controls.Add(maskedTextBoxTelefone);
            panel1.Controls.Add(maskedTextBoxCpf);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(labelTelefone);
            panel1.Controls.Add(labelCpf);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelNome);
            panel1.Location = new Point(21, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 250);
            panel1.TabIndex = 17;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCliente.Location = new Point(14, 14);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(103, 38);
            labelCliente.TabIndex = 12;
            labelCliente.Text = "Cliente";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtLogradouro);
            panel2.Controls.Add(labelLogradouro);
            panel2.Controls.Add(txtCEP);
            panel2.Controls.Add(labelCep);
            panel2.Controls.Add(txtComplemento);
            panel2.Controls.Add(labelRua);
            panel2.Controls.Add(labelBairro);
            panel2.Controls.Add(labelComplemento);
            panel2.Controls.Add(txtRua);
            panel2.Controls.Add(txtBairro);
            panel2.Location = new Point(375, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 250);
            panel2.TabIndex = 18;
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(42, 96);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 20);
            labelCep.TabIndex = 14;
            labelCep.Text = "CEP";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(112, 89);
            txtCEP.Margin = new Padding(3, 4, 3, 4);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(175, 27);
            txtCEP.TabIndex = 15;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(113, 53);
            txtLogradouro.Margin = new Padding(3, 4, 3, 4);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(175, 27);
            txtLogradouro.TabIndex = 17;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(20, 60);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(87, 20);
            labelLogradouro.TabIndex = 16;
            labelLogradouro.Text = "Logradouro";
            // 
            // CadastroDeClientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(908, 421);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDeClientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeClientesForm";
            FormClosing += CadastroDeClientesForm_FormClosing;
            Load += CadastroDeClientesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txtRua;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnLimpar;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxTelefone;
        private Panel panel1;
        private Label labelCliente;
        private Panel panel2;
        private TextBox txtLogradouro;
        private Label labelLogradouro;
        private TextBox txtCEP;
        private Label labelCep;
    }
}