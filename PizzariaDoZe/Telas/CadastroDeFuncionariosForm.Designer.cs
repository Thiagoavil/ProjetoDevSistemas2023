namespace PizzariaDoZe.Telas
{
    partial class CadastroDeFuncionariosForm
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
            txtNome = new TextBox();
            labelTelefone = new Label();
            labelCpf = new Label();
            labelNome = new Label();
            labelSenha = new Label();
            labelCnh = new Label();
            labelValidadecnh = new Label();
            txtSenha = new TextBox();
            DatePickerValidadeCNH = new DateTimePicker();
            TxtCnh = new MaskedTextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnLimpar = new Button();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            panel2 = new Panel();
            txtNumero = new TextBox();
            labelNumero = new Label();
            txtId = new TextBox();
            labelId = new Label();
            txtPais = new TextBox();
            labelPais = new Label();
            comboBoxUf = new ComboBox();
            labelUF = new Label();
            txtCidade = new TextBox();
            labelCidade = new Label();
            maskedTextBoxCep = new MaskedTextBox();
            txtLogradouro = new TextBox();
            labelLogradouro = new Label();
            labelCep = new Label();
            txtComplemento = new TextBox();
            labelBairro = new Label();
            labelComplemento = new Label();
            txtBairro = new TextBox();
            labelMatricula = new Label();
            txtMatricula = new TextBox();
            GorupBoxGrupo = new GroupBox();
            radioButtonGrupoEntregador = new RadioButton();
            radioButtonGrupoAtendente = new RadioButton();
            radioButtonGrupoAdmin = new RadioButton();
            labelObservações = new Label();
            txtObservacoes = new TextBox();
            labelEmail = new Label();
            txtEmail = new TextBox();
            panel2.SuspendLayout();
            GorupBoxGrupo.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(95, 49);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 27);
            txtNome.TabIndex = 0;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(30, 108);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(66, 20);
            labelTelefone.TabIndex = 15;
            labelTelefone.Text = "Telefone";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(30, 163);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 20);
            labelCpf.TabIndex = 14;
            labelCpf.Text = "CPF";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(30, 53);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 13;
            labelNome.Text = "Nome";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(296, 53);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 19;
            labelSenha.Text = "Senha";
            // 
            // labelCnh
            // 
            labelCnh.AutoSize = true;
            labelCnh.Location = new Point(30, 206);
            labelCnh.Name = "labelCnh";
            labelCnh.Size = new Size(34, 20);
            labelCnh.TabIndex = 21;
            labelCnh.Text = "Cnh";
            // 
            // labelValidadecnh
            // 
            labelValidadecnh.AutoSize = true;
            labelValidadecnh.Location = new Point(299, 272);
            labelValidadecnh.Name = "labelValidadecnh";
            labelValidadecnh.Size = new Size(119, 20);
            labelValidadecnh.TabIndex = 22;
            labelValidadecnh.Text = "Validade Da Cnh";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(351, 49);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(161, 27);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // DatePickerValidadeCNH
            // 
            DatePickerValidadeCNH.Format = DateTimePickerFormat.Short;
            DatePickerValidadeCNH.Location = new Point(413, 268);
            DatePickerValidadeCNH.Margin = new Padding(3, 4, 3, 4);
            DatePickerValidadeCNH.Name = "DatePickerValidadeCNH";
            DatePickerValidadeCNH.Size = new Size(99, 27);
            DatePickerValidadeCNH.TabIndex = 6;
            // 
            // TxtCnh
            // 
            TxtCnh.Location = new Point(95, 202);
            TxtCnh.Margin = new Padding(3, 4, 3, 4);
            TxtCnh.Mask = "000000000000";
            TxtCnh.Name = "TxtCnh";
            TxtCnh.Size = new Size(138, 27);
            TxtCnh.TabIndex = 5;
            TxtCnh.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(350, 352);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 76);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(30, 352);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 76);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(190, 352);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 76);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(95, 160);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(161, 27);
            maskedTextBoxCpf.TabIndex = 3;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(95, 105);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(161, 27);
            maskedTextBoxTelefone.TabIndex = 2;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNumero);
            panel2.Controls.Add(labelNumero);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(labelId);
            panel2.Controls.Add(txtPais);
            panel2.Controls.Add(labelPais);
            panel2.Controls.Add(comboBoxUf);
            panel2.Controls.Add(labelUF);
            panel2.Controls.Add(txtCidade);
            panel2.Controls.Add(labelCidade);
            panel2.Controls.Add(maskedTextBoxCep);
            panel2.Controls.Add(txtLogradouro);
            panel2.Controls.Add(labelLogradouro);
            panel2.Controls.Add(labelCep);
            panel2.Controls.Add(txtComplemento);
            panel2.Controls.Add(labelBairro);
            panel2.Controls.Add(labelComplemento);
            panel2.Controls.Add(txtBairro);
            panel2.Location = new Point(546, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 250);
            panel2.TabIndex = 23;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(366, 127);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(126, 27);
            txtNumero.TabIndex = 28;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(297, 129);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(63, 20);
            labelNumero.TabIndex = 27;
            labelNumero.Text = "Numero";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(364, 206);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 27);
            txtId.TabIndex = 26;
            txtId.TabStop = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(336, 209);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 25;
            labelId.Text = "Id";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(366, 71);
            txtPais.Margin = new Padding(3, 4, 3, 4);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(126, 27);
            txtPais.TabIndex = 24;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(326, 74);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(34, 20);
            labelPais.TabIndex = 23;
            labelPais.Text = "Pais";
            // 
            // comboBoxUf
            // 
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Location = new Point(366, 33);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(126, 28);
            comboBoxUf.TabIndex = 22;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Location = new Point(336, 36);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(24, 20);
            labelUF.TabIndex = 21;
            labelUF.Text = "Uf";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(112, 21);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(175, 27);
            txtCidade.TabIndex = 20;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(50, 28);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 19;
            labelCidade.Text = "Cidade";
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(112, 93);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(161, 27);
            maskedTextBoxCep.TabIndex = 18;
            maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(112, 57);
            txtLogradouro.Margin = new Padding(3, 4, 3, 4);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(175, 27);
            txtLogradouro.TabIndex = 17;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(19, 62);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(87, 20);
            labelLogradouro.TabIndex = 16;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(72, 96);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 20);
            labelCep.TabIndex = 14;
            labelCep.Text = "CEP";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(112, 129);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(175, 27);
            txtComplemento.TabIndex = 13;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(57, 167);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 5;
            labelBairro.Text = "Bairro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(2, 130);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 6;
            labelComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(112, 164);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(161, 27);
            txtBairro.TabIndex = 10;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(274, 87);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(71, 20);
            labelMatricula.TabIndex = 24;
            labelMatricula.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(351, 84);
            txtMatricula.Margin = new Padding(3, 4, 3, 4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(161, 27);
            txtMatricula.TabIndex = 25;
            // 
            // GorupBoxGrupo
            // 
            GorupBoxGrupo.Controls.Add(radioButtonGrupoEntregador);
            GorupBoxGrupo.Controls.Add(radioButtonGrupoAtendente);
            GorupBoxGrupo.Controls.Add(radioButtonGrupoAdmin);
            GorupBoxGrupo.Location = new Point(296, 118);
            GorupBoxGrupo.Name = "GorupBoxGrupo";
            GorupBoxGrupo.Size = new Size(212, 129);
            GorupBoxGrupo.TabIndex = 26;
            GorupBoxGrupo.TabStop = false;
            GorupBoxGrupo.Text = "Grupo";
            // 
            // radioButtonGrupoEntregador
            // 
            radioButtonGrupoEntregador.AutoSize = true;
            radioButtonGrupoEntregador.Location = new Point(21, 91);
            radioButtonGrupoEntregador.Name = "radioButtonGrupoEntregador";
            radioButtonGrupoEntregador.Size = new Size(104, 24);
            radioButtonGrupoEntregador.TabIndex = 2;
            radioButtonGrupoEntregador.TabStop = true;
            radioButtonGrupoEntregador.Text = "Entregador";
            radioButtonGrupoEntregador.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrupoAtendente
            // 
            radioButtonGrupoAtendente.AutoSize = true;
            radioButtonGrupoAtendente.Location = new Point(21, 56);
            radioButtonGrupoAtendente.Name = "radioButtonGrupoAtendente";
            radioButtonGrupoAtendente.Size = new Size(99, 24);
            radioButtonGrupoAtendente.TabIndex = 1;
            radioButtonGrupoAtendente.TabStop = true;
            radioButtonGrupoAtendente.Text = "Atentende";
            radioButtonGrupoAtendente.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrupoAdmin
            // 
            radioButtonGrupoAdmin.AutoSize = true;
            radioButtonGrupoAdmin.Location = new Point(21, 26);
            radioButtonGrupoAdmin.Name = "radioButtonGrupoAdmin";
            radioButtonGrupoAdmin.Size = new Size(126, 24);
            radioButtonGrupoAdmin.TabIndex = 0;
            radioButtonGrupoAdmin.TabStop = true;
            radioButtonGrupoAdmin.Text = "Administração";
            radioButtonGrupoAdmin.UseVisualStyleBackColor = true;
            // 
            // labelObservações
            // 
            labelObservações.AutoSize = true;
            labelObservações.Location = new Point(30, 291);
            labelObservações.Name = "labelObservações";
            labelObservações.Size = new Size(93, 20);
            labelObservações.TabIndex = 27;
            labelObservações.Text = "Observações";
            labelObservações.Click += labelObservações_Click;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(30, 314);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(156, 27);
            txtObservacoes.TabIndex = 28;
            txtObservacoes.TextChanged += txtObservacoes_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Khaki;
            labelEmail.Location = new Point(30, 251);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 29;
            labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 251);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 30;
            // 
            // CadastroDeFuncionariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1117, 444);
            Controls.Add(txtEmail);
            Controls.Add(labelEmail);
            Controls.Add(txtObservacoes);
            Controls.Add(labelObservações);
            Controls.Add(GorupBoxGrupo);
            Controls.Add(txtMatricula);
            Controls.Add(labelMatricula);
            Controls.Add(panel2);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(TxtCnh);
            Controls.Add(DatePickerValidadeCNH);
            Controls.Add(txtSenha);
            Controls.Add(labelValidadecnh);
            Controls.Add(labelCnh);
            Controls.Add(labelSenha);
            Controls.Add(txtNome);
            Controls.Add(labelTelefone);
            Controls.Add(labelCpf);
            Controls.Add(labelNome);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDeFuncionariosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeFuncionariosForm";
            FormClosing += CadastroDeFuncionariosForm_FormClosing;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            GorupBoxGrupo.ResumeLayout(false);
            GorupBoxGrupo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label labelTelefone;
        private Label labelCpf;
        private Label labelNome;
        private Label labelSenha;
        private Label labelCnh;
        private Label labelValidadecnh;
        private TextBox txtSenha;
        private DateTimePicker DatePickerValidadeCNH;
        private MaskedTextBox TxtCnh;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnLimpar;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxTelefone;
        private Panel panel2;
        private TextBox txtNumero;
        private Label labelNumero;
        private TextBox txtId;
        private Label labelId;
        private TextBox txtPais;
        private Label labelPais;
        private ComboBox comboBoxUf;
        private Label labelUF;
        private TextBox txtCidade;
        private Label labelCidade;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox txtLogradouro;
        private Label labelLogradouro;
        private Label labelCep;
        private TextBox txtComplemento;
        private Label labelBairro;
        private Label labelComplemento;
        private TextBox txtBairro;
        private Label labelMatricula;
        private TextBox txtMatricula;
        private GroupBox GorupBoxGrupo;
        private RadioButton radioButtonGrupoEntregador;
        private RadioButton radioButtonGrupoAtendente;
        private RadioButton radioButtonGrupoAdmin;
        private Label labelObservações;
        private TextBox txtObservacoes;
        private Label labelEmail;
        private TextBox txtEmail;
    }
}