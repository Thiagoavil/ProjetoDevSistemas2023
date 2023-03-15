namespace PizzariaDoZe.Telas
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelLogo = new Label();
            panel2 = new Panel();
            btnIconIngredientes = new Button();
            btnIconSabores = new Button();
            btnIconFuncionario = new Button();
            btnIconCliente = new Button();
            btnCadastroDeIngredientes = new Button();
            btnCadastroDeSabores = new Button();
            btnCadastroDeFuncionarios = new Button();
            btnCadastrarCliente = new Button();
            panel3 = new Panel();
            btnSearch = new Button();
            Searchtxt = new TextBox();
            tabControlCadastros = new TabControl();
            ListarClientes = new TabPage();
            ListarFuncionários = new TabPage();
            ListarSabores = new TabPage();
            ListarIngredientes = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnIconEditar = new Button();
            btnIconExcluir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControlCadastros.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelLogo);
            panel1.Location = new Point(9, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 143);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(334, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 137);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(557, 41);
            label1.Name = "label1";
            label1.Size = new Size(296, 62);
            label1.TabIndex = 1;
            label1.Text = "Tela Principal";
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.BackColor = Color.Transparent;
            labelLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogo.ForeColor = Color.Khaki;
            labelLogo.Location = new Point(24, 17);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(217, 108);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "Pizzaria \r\n        Do zé";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnIconIngredientes);
            panel2.Controls.Add(btnIconSabores);
            panel2.Controls.Add(btnIconFuncionario);
            panel2.Controls.Add(btnIconCliente);
            panel2.Controls.Add(btnCadastroDeIngredientes);
            panel2.Controls.Add(btnCadastroDeSabores);
            panel2.Controls.Add(btnCadastroDeFuncionarios);
            panel2.Controls.Add(btnCadastrarCliente);
            panel2.Location = new Point(10, 177);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 481);
            panel2.TabIndex = 1;
            // 
            // btnIconIngredientes
            // 
            btnIconIngredientes.BackgroundImage = (Image)resources.GetObject("btnIconIngredientes.BackgroundImage");
            btnIconIngredientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconIngredientes.FlatStyle = FlatStyle.Flat;
            btnIconIngredientes.Location = new Point(8, 359);
            btnIconIngredientes.Name = "btnIconIngredientes";
            btnIconIngredientes.Size = new Size(53, 49);
            btnIconIngredientes.TabIndex = 7;
            btnIconIngredientes.UseVisualStyleBackColor = true;
            // 
            // btnIconSabores
            // 
            btnIconSabores.BackgroundImage = (Image)resources.GetObject("btnIconSabores.BackgroundImage");
            btnIconSabores.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconSabores.FlatStyle = FlatStyle.Flat;
            btnIconSabores.Location = new Point(8, 250);
            btnIconSabores.Name = "btnIconSabores";
            btnIconSabores.Size = new Size(53, 49);
            btnIconSabores.TabIndex = 6;
            btnIconSabores.UseVisualStyleBackColor = true;
            // 
            // btnIconFuncionario
            // 
            btnIconFuncionario.BackColor = Color.Transparent;
            btnIconFuncionario.BackgroundImage = (Image)resources.GetObject("btnIconFuncionario.BackgroundImage");
            btnIconFuncionario.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconFuncionario.FlatStyle = FlatStyle.Flat;
            btnIconFuncionario.Location = new Point(8, 137);
            btnIconFuncionario.Name = "btnIconFuncionario";
            btnIconFuncionario.Size = new Size(53, 49);
            btnIconFuncionario.TabIndex = 5;
            btnIconFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnIconCliente
            // 
            btnIconCliente.BackColor = Color.Transparent;
            btnIconCliente.BackgroundImage = (Image)resources.GetObject("btnIconCliente.BackgroundImage");
            btnIconCliente.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconCliente.FlatStyle = FlatStyle.Flat;
            btnIconCliente.Location = new Point(8, 32);
            btnIconCliente.Name = "btnIconCliente";
            btnIconCliente.Size = new Size(53, 49);
            btnIconCliente.TabIndex = 4;
            btnIconCliente.UseVisualStyleBackColor = false;
            // 
            // btnCadastroDeIngredientes
            // 
            btnCadastroDeIngredientes.FlatStyle = FlatStyle.Popup;
            btnCadastroDeIngredientes.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroDeIngredientes.Location = new Point(67, 359);
            btnCadastroDeIngredientes.Margin = new Padding(3, 4, 3, 4);
            btnCadastroDeIngredientes.Name = "btnCadastroDeIngredientes";
            btnCadastroDeIngredientes.Size = new Size(173, 49);
            btnCadastroDeIngredientes.TabIndex = 3;
            btnCadastroDeIngredientes.Text = "Cadastro de Ingredientes";
            btnCadastroDeIngredientes.UseVisualStyleBackColor = true;
            btnCadastroDeIngredientes.Click += btnCadastroDeIngredientes_Click;
            // 
            // btnCadastroDeSabores
            // 
            btnCadastroDeSabores.FlatStyle = FlatStyle.Popup;
            btnCadastroDeSabores.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroDeSabores.Location = new Point(67, 250);
            btnCadastroDeSabores.Margin = new Padding(3, 4, 3, 4);
            btnCadastroDeSabores.Name = "btnCadastroDeSabores";
            btnCadastroDeSabores.Size = new Size(173, 49);
            btnCadastroDeSabores.TabIndex = 2;
            btnCadastroDeSabores.Text = "Cadastro de Sabores";
            btnCadastroDeSabores.UseVisualStyleBackColor = true;
            btnCadastroDeSabores.Click += btnCadastroDeSabores_Click;
            // 
            // btnCadastroDeFuncionarios
            // 
            btnCadastroDeFuncionarios.FlatStyle = FlatStyle.Popup;
            btnCadastroDeFuncionarios.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroDeFuncionarios.Location = new Point(67, 137);
            btnCadastroDeFuncionarios.Margin = new Padding(3, 4, 3, 4);
            btnCadastroDeFuncionarios.Name = "btnCadastroDeFuncionarios";
            btnCadastroDeFuncionarios.Size = new Size(173, 49);
            btnCadastroDeFuncionarios.TabIndex = 1;
            btnCadastroDeFuncionarios.Text = "Cadastro de Funcionário";
            btnCadastroDeFuncionarios.UseVisualStyleBackColor = true;
            btnCadastroDeFuncionarios.Click += btnCadastroDeFuncionarios_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.FlatStyle = FlatStyle.Popup;
            btnCadastrarCliente.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarCliente.Location = new Point(67, 32);
            btnCadastrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(173, 49);
            btnCadastrarCliente.TabIndex = 0;
            btnCadastrarCliente.Text = "Cadastro de Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnIconExcluir);
            panel3.Controls.Add(btnIconEditar);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(Searchtxt);
            panel3.Controls.Add(tabControlCadastros);
            panel3.Location = new Point(294, 177);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(697, 481);
            panel3.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(345, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(39, 28);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Searchtxt
            // 
            Searchtxt.Location = new Point(20, 32);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(319, 27);
            Searchtxt.TabIndex = 1;
            // 
            // tabControlCadastros
            // 
            tabControlCadastros.Controls.Add(ListarClientes);
            tabControlCadastros.Controls.Add(ListarFuncionários);
            tabControlCadastros.Controls.Add(ListarSabores);
            tabControlCadastros.Controls.Add(ListarIngredientes);
            tabControlCadastros.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlCadastros.Location = new Point(20, 66);
            tabControlCadastros.Name = "tabControlCadastros";
            tabControlCadastros.SelectedIndex = 0;
            tabControlCadastros.Size = new Size(651, 398);
            tabControlCadastros.TabIndex = 0;
            // 
            // ListarClientes
            // 
            ListarClientes.Location = new Point(4, 29);
            ListarClientes.Name = "ListarClientes";
            ListarClientes.Padding = new Padding(3);
            ListarClientes.Size = new Size(643, 365);
            ListarClientes.TabIndex = 0;
            ListarClientes.Text = "Clientes";
            ListarClientes.UseVisualStyleBackColor = true;
            // 
            // ListarFuncionários
            // 
            ListarFuncionários.Location = new Point(4, 29);
            ListarFuncionários.Name = "ListarFuncionários";
            ListarFuncionários.Padding = new Padding(3);
            ListarFuncionários.Size = new Size(643, 365);
            ListarFuncionários.TabIndex = 1;
            ListarFuncionários.Text = "Funcionários";
            ListarFuncionários.UseVisualStyleBackColor = true;
            // 
            // ListarSabores
            // 
            ListarSabores.Location = new Point(4, 29);
            ListarSabores.Name = "ListarSabores";
            ListarSabores.Size = new Size(643, 365);
            ListarSabores.TabIndex = 2;
            ListarSabores.Text = "Sabores";
            ListarSabores.UseVisualStyleBackColor = true;
            // 
            // ListarIngredientes
            // 
            ListarIngredientes.Location = new Point(4, 29);
            ListarIngredientes.Name = "ListarIngredientes";
            ListarIngredientes.Size = new Size(643, 365);
            ListarIngredientes.TabIndex = 3;
            ListarIngredientes.Text = "Ingredientes";
            ListarIngredientes.UseVisualStyleBackColor = true;
            // 
            // btnIconEditar
            // 
            btnIconEditar.BackColor = Color.Transparent;
            btnIconEditar.BackgroundImage = (Image)resources.GetObject("btnIconEditar.BackgroundImage");
            btnIconEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconEditar.FlatStyle = FlatStyle.Flat;
            btnIconEditar.Location = new Point(395, 31);
            btnIconEditar.Name = "btnIconEditar";
            btnIconEditar.Size = new Size(39, 28);
            btnIconEditar.TabIndex = 5;
            btnIconEditar.UseVisualStyleBackColor = false;
            // 
            // btnIconExcluir
            // 
            btnIconExcluir.BackColor = Color.Transparent;
            btnIconExcluir.BackgroundImage = (Image)resources.GetObject("btnIconExcluir.BackgroundImage");
            btnIconExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconExcluir.FlatStyle = FlatStyle.Flat;
            btnIconExcluir.Location = new Point(445, 31);
            btnIconExcluir.Name = "btnIconExcluir";
            btnIconExcluir.Size = new Size(39, 28);
            btnIconExcluir.TabIndex = 6;
            btnIconExcluir.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1003, 671);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria Do zé";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControlCadastros.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCadastrarCliente;
        private Panel panel3;
        private Button btnCadastroDeIngredientes;
        private Button btnCadastroDeSabores;
        private Button btnCadastroDeFuncionarios;
        private Label label1;
        private Label labelLogo;
        private TabControl tabControlCadastros;
        private TabPage ListarClientes;
        private TabPage ListarFuncionários;
        private TabPage ListarSabores;
        private TabPage ListarIngredientes;
        private Button btnSearch;
        private TextBox Searchtxt;
        private Button btnIconIngredientes;
        private Button btnIconSabores;
        private Button btnIconFuncionario;
        private Button btnIconCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Button btnIconExcluir;
        private Button btnIconEditar;
    }
}