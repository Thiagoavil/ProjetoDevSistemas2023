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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Telalabel = new Label();
            labelLogo = new Label();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCadastrarProduto = new Button();
            btnCadastroValores = new Button();
            btnCadastroDeIngredientes = new Button();
            btnCadastroDeSabores = new Button();
            btnCadastroDeFuncionarios = new Button();
            btnCadastrarCliente = new Button();
            panel3 = new Panel();
            btnIconExcluir = new Button();
            btnIconEditar = new Button();
            btnSearch = new Button();
            Searchtxt = new TextBox();
            tabControlCadastros = new TabControl();
            ListarClientes = new TabPage();
            ListarFuncionários = new TabPage();
            ListarSabores = new TabPage();
            ListarIngredientes = new TabPage();
            ListarTamanhos = new TabPage();
            ListarProdutos = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            imageList1 = new ImageList(components);
            pictureBox8 = new PictureBox();
            ConfiguraçõesBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            tabControlCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Telalabel);
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
            // Telalabel
            // 
            Telalabel.AutoSize = true;
            Telalabel.BackColor = Color.Transparent;
            Telalabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Telalabel.ForeColor = Color.Khaki;
            Telalabel.Location = new Point(557, 41);
            Telalabel.Name = "Telalabel";
            Telalabel.Size = new Size(296, 62);
            Telalabel.TabIndex = 1;
            Telalabel.Text = "Tela Principal";
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
            panel2.Controls.Add(ConfiguraçõesBtn);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnCadastrarProduto);
            panel2.Controls.Add(btnCadastroValores);
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
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.None;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(3, 312);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.InitialImage = (Image)resources.GetObject("pictureBox6.InitialImage");
            pictureBox6.Location = new Point(3, 256);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.ErrorImage = (Image)resources.GetObject("pictureBox5.ErrorImage");
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(3, 200);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(3, 144);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(3, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(3, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.FlatStyle = FlatStyle.Popup;
            btnCadastrarProduto.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarProduto.Location = new Point(67, 312);
            btnCadastrarProduto.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(173, 49);
            btnCadastrarProduto.TabIndex = 10;
            btnCadastrarProduto.Text = "Cadastro de Produtos";
            btnCadastrarProduto.UseVisualStyleBackColor = true;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // btnCadastroValores
            // 
            btnCadastroValores.FlatStyle = FlatStyle.Popup;
            btnCadastroValores.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroValores.Location = new Point(67, 256);
            btnCadastroValores.Margin = new Padding(3, 4, 3, 4);
            btnCadastroValores.Name = "btnCadastroValores";
            btnCadastroValores.Size = new Size(173, 49);
            btnCadastroValores.TabIndex = 8;
            btnCadastroValores.Text = "Cadastro de Valores";
            btnCadastroValores.UseVisualStyleBackColor = true;
            btnCadastroValores.Click += btnCadastroValores_Click;
            // 
            // btnCadastroDeIngredientes
            // 
            btnCadastroDeIngredientes.FlatStyle = FlatStyle.Popup;
            btnCadastroDeIngredientes.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroDeIngredientes.Location = new Point(67, 200);
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
            btnCadastroDeSabores.Location = new Point(67, 144);
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
            btnCadastroDeFuncionarios.Location = new Point(67, 88);
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
            tabControlCadastros.Controls.Add(ListarTamanhos);
            tabControlCadastros.Controls.Add(ListarProdutos);
            tabControlCadastros.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlCadastros.Location = new Point(20, 66);
            tabControlCadastros.Name = "tabControlCadastros";
            tabControlCadastros.SelectedIndex = 0;
            tabControlCadastros.Size = new Size(651, 398);
            tabControlCadastros.SizeMode = TabSizeMode.FillToRight;
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
            // ListarTamanhos
            // 
            ListarTamanhos.Location = new Point(4, 29);
            ListarTamanhos.Name = "ListarTamanhos";
            ListarTamanhos.Size = new Size(643, 365);
            ListarTamanhos.TabIndex = 4;
            ListarTamanhos.Text = "Tamanhos";
            ListarTamanhos.UseVisualStyleBackColor = true;
            // 
            // ListarProdutos
            // 
            ListarProdutos.Location = new Point(4, 29);
            ListarProdutos.Name = "ListarProdutos";
            ListarProdutos.Size = new Size(643, 365);
            ListarProdutos.TabIndex = 5;
            ListarProdutos.Text = "Produtos";
            ListarProdutos.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.None;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.InitialImage = (Image)resources.GetObject("pictureBox8.InitialImage");
            pictureBox8.Location = new Point(3, 368);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(58, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // ConfiguraçõesBtn
            // 
            ConfiguraçõesBtn.FlatStyle = FlatStyle.Popup;
            ConfiguraçõesBtn.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ConfiguraçõesBtn.Location = new Point(67, 368);
            ConfiguraçõesBtn.Margin = new Padding(3, 4, 3, 4);
            ConfiguraçõesBtn.Name = "ConfiguraçõesBtn";
            ConfiguraçõesBtn.Size = new Size(173, 49);
            ConfiguraçõesBtn.TabIndex = 18;
            ConfiguraçõesBtn.Text = "Configurações";
            ConfiguraçõesBtn.UseVisualStyleBackColor = true;
            ConfiguraçõesBtn.Click += ConfiguraçõesBtn_Click;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControlCadastros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
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
        private Label Telalabel;
        private Label labelLogo;
        private TabControl tabControlCadastros;
        private TabPage ListarClientes;
        private TabPage ListarFuncionários;
        private TabPage ListarSabores;
        private TabPage ListarIngredientes;
        private Button btnSearch;
        private TextBox Searchtxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Button btnIconExcluir;
        private Button btnIconEditar;
        private Button btnCadastrarProduto;
        private Button btnCadastroValores;
        private TabPage ListarTamanhos;
        private TabPage ListarProdutos;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        private Button ConfiguraçõesBtn;
        private PictureBox pictureBox8;
    }
}