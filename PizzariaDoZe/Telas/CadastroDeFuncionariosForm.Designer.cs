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
            labelFuncao = new Label();
            labelCnh = new Label();
            labelValidadecnh = new Label();
            txtSenha = new TextBox();
            DatePickerValidadeCNH = new DateTimePicker();
            TxtCnh = new MaskedTextBox();
            CbFuncao = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnLimpar = new Button();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
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
            labelSenha.Location = new Point(299, 53);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 19;
            labelSenha.Text = "Senha";
            // 
            // labelFuncao
            // 
            labelFuncao.AutoSize = true;
            labelFuncao.Location = new Point(30, 217);
            labelFuncao.Name = "labelFuncao";
            labelFuncao.Size = new Size(56, 20);
            labelFuncao.TabIndex = 20;
            labelFuncao.Text = "Função";
            // 
            // labelCnh
            // 
            labelCnh.AutoSize = true;
            labelCnh.Location = new Point(30, 272);
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
            TxtCnh.Location = new Point(95, 268);
            TxtCnh.Margin = new Padding(3, 4, 3, 4);
            TxtCnh.Mask = "000000000000";
            TxtCnh.Name = "TxtCnh";
            TxtCnh.Size = new Size(138, 27);
            TxtCnh.TabIndex = 5;
            // 
            // CbFuncao
            // 
            CbFuncao.FormattingEnabled = true;
            CbFuncao.Location = new Point(95, 213);
            CbFuncao.Margin = new Padding(3, 4, 3, 4);
            CbFuncao.Name = "CbFuncao";
            CbFuncao.Size = new Size(138, 28);
            CbFuncao.TabIndex = 4;
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
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(95, 105);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(161, 27);
            maskedTextBoxTelefone.TabIndex = 2;
            // 
            // CadastroDeFuncionariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(534, 444);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(CbFuncao);
            Controls.Add(TxtCnh);
            Controls.Add(DatePickerValidadeCNH);
            Controls.Add(txtSenha);
            Controls.Add(labelValidadecnh);
            Controls.Add(labelCnh);
            Controls.Add(labelFuncao);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label labelTelefone;
        private Label labelCpf;
        private Label labelNome;
        private Label labelSenha;
        private Label labelFuncao;
        private Label labelCnh;
        private Label labelValidadecnh;
        private TextBox txtSenha;
        private DateTimePicker DatePickerValidadeCNH;
        private MaskedTextBox TxtCnh;
        private ComboBox CbFuncao;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnLimpar;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxTelefone;
    }
}