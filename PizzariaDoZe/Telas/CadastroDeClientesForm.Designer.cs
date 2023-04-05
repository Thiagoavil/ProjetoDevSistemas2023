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
            labelNome.Location = new Point(41, 35);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            labelNome.Click += labelNome_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(41, 83);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(41, 131);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 20);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF";
            labelCpf.Click += labelCpf_Click;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(262, 35);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(66, 20);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Location = new Point(42, 187);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(34, 20);
            labelRua.TabIndex = 4;
            labelRua.Text = "Rua";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(262, 83);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 5;
            labelBairro.Text = "Bairro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(41, 237);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 6;
            labelComplemento.Text = "Complemento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 31);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 27);
            txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 79);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(94, 127);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(161, 27);
            txtCpf.TabIndex = 9;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(94, 183);
            txtRua.Margin = new Padding(3, 4, 3, 4);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(161, 27);
            txtRua.TabIndex = 10;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(144, 233);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(175, 27);
            txtComplemento.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(327, 31);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(161, 27);
            txtTelefone.TabIndex = 12;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(327, 79);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(161, 27);
            txtBairro.TabIndex = 13;
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
            btnSalvar.TabIndex = 15;
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
            btnLimpar.TabIndex = 31;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // CadastroDeClientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(506, 421);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDeClientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroDeClientesForm";
            Load += CadastroDeClientesForm_Load;
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