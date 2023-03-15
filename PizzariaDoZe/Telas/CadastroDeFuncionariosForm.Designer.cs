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
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            labelTelefone = new Label();
            labelCpf = new Label();
            labelNome = new Label();
            labelSenha = new Label();
            labelFuncao = new Label();
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            DatePickerValidadeCNH = new DateTimePicker();
            TxtCnh = new MaskedTextBox();
            CbFuncao = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(83, 78);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(141, 23);
            txtTelefone.TabIndex = 18;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(83, 119);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(141, 23);
            txtCpf.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(141, 23);
            txtNome.TabIndex = 16;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(26, 81);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 15;
            labelTelefone.Text = "Telefone";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(26, 122);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(28, 15);
            labelCpf.TabIndex = 14;
            labelCpf.Text = "CPF";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(26, 40);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 13;
            labelNome.Text = "Nome";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(262, 40);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 19;
            labelSenha.Text = "Senha";
            // 
            // labelFuncao
            // 
            labelFuncao.AutoSize = true;
            labelFuncao.Location = new Point(26, 163);
            labelFuncao.Name = "labelFuncao";
            labelFuncao.Size = new Size(46, 15);
            labelFuncao.TabIndex = 20;
            labelFuncao.Text = "Função";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 204);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 21;
            label1.Text = "Cnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 204);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 22;
            label2.Text = "Validade Da Cnh";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(307, 37);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(141, 23);
            txtSenha.TabIndex = 24;
            // 
            // DatePickerValidadeCNH
            // 
            DatePickerValidadeCNH.Format = DateTimePickerFormat.Short;
            DatePickerValidadeCNH.Location = new Point(361, 201);
            DatePickerValidadeCNH.Name = "DatePickerValidadeCNH";
            DatePickerValidadeCNH.Size = new Size(87, 23);
            DatePickerValidadeCNH.TabIndex = 25;
            // 
            // TxtCnh
            // 
            TxtCnh.Location = new Point(83, 201);
            TxtCnh.Mask = "00000000000";
            TxtCnh.Name = "TxtCnh";
            TxtCnh.Size = new Size(121, 23);
            TxtCnh.TabIndex = 26;
            // 
            // CbFuncao
            // 
            CbFuncao.FormattingEnabled = true;
            CbFuncao.Location = new Point(83, 160);
            CbFuncao.Name = "CbFuncao";
            CbFuncao.Size = new Size(121, 23);
            CbFuncao.TabIndex = 27;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(306, 264);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(109, 57);
            btnSalvar.TabIndex = 29;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(26, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 57);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(166, 264);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(109, 57);
            btnLimpar.TabIndex = 30;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // CadastroDeFuncionariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(467, 333);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(CbFuncao);
            Controls.Add(TxtCnh);
            Controls.Add(DatePickerValidadeCNH);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelFuncao);
            Controls.Add(labelSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(labelTelefone);
            Controls.Add(labelCpf);
            Controls.Add(labelNome);
            Name = "CadastroDeFuncionariosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeFuncionariosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNome;
        private Label labelTelefone;
        private Label labelCpf;
        private Label labelNome;
        private Label labelSenha;
        private Label labelFuncao;
        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private DateTimePicker DatePickerValidadeCNH;
        private MaskedTextBox TxtCnh;
        private ComboBox CbFuncao;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnLimpar;
    }
}