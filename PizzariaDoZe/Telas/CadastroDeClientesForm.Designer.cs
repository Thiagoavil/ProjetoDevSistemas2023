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
            labelBairro = new Label();
            labelComplemento = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
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
            // txtComplemento
            // 
            txtComplemento.Location = new Point(112, 129);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(175, 27);
            txtComplemento.TabIndex = 13;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(112, 164);
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
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(79, 202);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(161, 27);
            maskedTextBoxTelefone.TabIndex = 8;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
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
            panel2.Location = new Point(365, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 250);
            panel2.TabIndex = 18;
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
            txtPais.TextChanged += textBox1_TextChanged;
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
            comboBoxUf.SelectedIndexChanged += comboBoxUf_SelectedIndexChanged;
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
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
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
        private Label labelBairro;
        private Label labelComplemento;
        private TextBox txtNome;
        private TextBox txtEmail;
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
        private Label labelCep;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox txtCidade;
        private Label labelCidade;
        private ComboBox comboBoxUf;
        private Label labelUF;
        private TextBox txtPais;
        private Label labelPais;
        private TextBox txtId;
        private Label labelId;
        private TextBox txtNumero;
        private Label labelNumero;
    }
}