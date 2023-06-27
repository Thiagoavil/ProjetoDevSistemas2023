namespace PizzariaDoZe.Telas
{
    partial class CadastroDePedidosForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            labelCpf = new Label();
            labelNome = new Label();
            maskedTextBoxCpf = new MaskedTextBox();
            txtNome = new TextBox();
            txtClienteId = new TextBox();
            labelId = new Label();
            labelValorTotal = new Label();
            maskedTextBoxValorTotal = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            labelPizzas = new Label();
            btnAdicionarPizza = new Button();
            btnAdicionarProdutos = new Button();
            labelItem = new Label();
            dataGridViewItens = new DataGridView();
            maskedTextBoxTelefone = new MaskedTextBox();
            labelTelefone = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(211, 48);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 20);
            labelCpf.TabIndex = 0;
            labelCpf.Text = "CPF";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(23, 48);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(213, 72);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(161, 27);
            maskedTextBoxCpf.TabIndex = 13;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(23, 72);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 27);
            txtNome.TabIndex = 12;
            // 
            // txtClienteId
            // 
            txtClienteId.Enabled = false;
            txtClienteId.Location = new Point(56, 13);
            txtClienteId.Margin = new Padding(3, 4, 3, 4);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(128, 27);
            txtClienteId.TabIndex = 28;
            txtClienteId.TabStop = false;
            txtClienteId.Visible = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(23, 20);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 27;
            labelId.Text = "Id";
            labelId.Visible = false;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Location = new Point(23, 534);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(42, 20);
            labelValorTotal.TabIndex = 31;
            labelValorTotal.Text = "Total";
            // 
            // maskedTextBoxValorTotal
            // 
            maskedTextBoxValorTotal.Location = new Point(71, 534);
            maskedTextBoxValorTotal.Mask = "$000,00";
            maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            maskedTextBoxValorTotal.Size = new Size(125, 27);
            maskedTextBoxValorTotal.TabIndex = 32;
            maskedTextBoxValorTotal.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(176, 299);
            dataGridView1.TabIndex = 37;
            // 
            // labelPizzas
            // 
            labelPizzas.AutoSize = true;
            labelPizzas.Location = new Point(23, 124);
            labelPizzas.Name = "labelPizzas";
            labelPizzas.Size = new Size(49, 20);
            labelPizzas.TabIndex = 38;
            labelPizzas.Text = "Pizzas";
            // 
            // btnAdicionarPizza
            // 
            btnAdicionarPizza.Location = new Point(23, 452);
            btnAdicionarPizza.Name = "btnAdicionarPizza";
            btnAdicionarPizza.Size = new Size(120, 48);
            btnAdicionarPizza.TabIndex = 39;
            btnAdicionarPizza.Text = "Adicionar Pizza";
            btnAdicionarPizza.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProdutos
            // 
            btnAdicionarProdutos.Location = new Point(248, 452);
            btnAdicionarProdutos.Name = "btnAdicionarProdutos";
            btnAdicionarProdutos.Size = new Size(120, 48);
            btnAdicionarProdutos.TabIndex = 42;
            btnAdicionarProdutos.Text = "Adicionar Produtos";
            btnAdicionarProdutos.UseVisualStyleBackColor = true;
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Location = new Point(248, 124);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(40, 20);
            labelItem.TabIndex = 41;
            labelItem.Text = "Itens";
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Location = new Point(248, 147);
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.RowHeadersWidth = 51;
            dataGridViewItens.RowTemplate.Height = 29;
            dataGridViewItens.Size = new Size(176, 299);
            dataGridViewItens.TabIndex = 40;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(403, 72);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(161, 27);
            maskedTextBoxTelefone.TabIndex = 44;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(403, 48);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(66, 20);
            labelTelefone.TabIndex = 43;
            labelTelefone.Text = "Telefone";
            // 
            // CadastroDePedidosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(682, 583);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(labelTelefone);
            Controls.Add(btnAdicionarProdutos);
            Controls.Add(labelItem);
            Controls.Add(dataGridViewItens);
            Controls.Add(btnAdicionarPizza);
            Controls.Add(labelPizzas);
            Controls.Add(dataGridView1);
            Controls.Add(maskedTextBoxValorTotal);
            Controls.Add(labelValorTotal);
            Controls.Add(txtClienteId);
            Controls.Add(labelId);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(txtNome);
            Controls.Add(labelNome);
            Controls.Add(labelCpf);
            Name = "CadastroDePedidosForm";
            Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label labelCpf;
        private Label labelNome;
        private MaskedTextBox maskedTextBoxCpf;
        private TextBox txtNome;
        private TextBox txtClienteId;
        private Label labelId;
        private Label labelValorTotal;
        private MaskedTextBox maskedTextBoxValorTotal;
        private DataGridView dataGridView1;
        private Label labelPizzas;
        private Button btnAdicionarPizza;
        private Button btnAdicionarProdutos;
        private Label labelItem;
        private DataGridView dataGridViewItens;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label labelTelefone;
    }
}