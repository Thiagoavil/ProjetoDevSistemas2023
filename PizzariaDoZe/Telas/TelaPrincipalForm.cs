using PizzariaDoZe.PastaEnums;
using PizzariaDoZe.Properties;
using PizzariaDoZe_DAO.PastaCliente;
using PizzariaDoZe_DAO.PastaEndereco;
using PizzariaDoZe_DAO.PastaFuncionario;
using PizzariaDoZe_DAO.PastaIngredientes;
using PizzariaDoZe_DAO.PastaProduto;
using PizzariaDoZe_DAO.PastaSabores;
using PizzariaDoZe_DAO.PastaValor;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PizzariaDoZe.Telas
{
    public partial class TelaPrincipalForm : Form
    {
        private IngredientesDAO ingredienteDAO;
        private EnderecoDAO enderecoDAO;
        private ClienteDAO clienteDAO;
        private FuncionarioDAO funcionarioDAO;
        private SaborDAO saborDAO;
        private ValorDAO valorDAO;
        private ProdutoDAO produtoDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            #region idioma/regi�o interface - satellite assembly
            // com base no idioma/regi�o escolhido pelo usu�rio,
            // ajusta as propriedades dos componentes da tela com base no conte�do do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usu�rio que n�o puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
            #region Configura��o De Bot�es no Foco
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            #endregion
            #region Enter Como Tab
            //Evento em Funcoes que congifura a tecla enter como o tab
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            #endregion
            #region Configura��o MenuStrip
            //inicioToolStripMenuItem.Click += new EventHandler(bt!);
            ClienteStripMenuItem.Click += new EventHandler(btnCadastrarCliente_Click!);
            funcionariosToolStripMenuItem.Click += new EventHandler(btnCadastroDeFuncionarios_Click!);
            saboresToolStripMenuItem.Click += new EventHandler(btnCadastroDeSabores_Click!);
            ingredientesToolStripMenuItem.Click += new EventHandler(btnCadastroDeIngredientes_Click!);
            valoresToolStripMenuItem.Click += new EventHandler(btnCadastroValores_Click!);
            produtosToolStripMenuItem.Click += new EventHandler(btnCadastrarProduto_Click!);
            configura��esToolStripMenuItem.Click += new EventHandler(Configura��esBtn_Click!);
            //sairToolStripMenuItem.Click += new EventHandler(TelaPrincipalForm_FormClosing!);
            #endregion
            #region configura��o idioma - MenuStrip 
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);
            #endregion
            #region DAO
            // cria a instancia da classe da model
            ingredienteDAO = new IngredientesDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            valorDAO = new ValorDAO(provider, strConnection);
            produtoDAO = new ProdutoDAO(provider, strConnection);
            #endregion
            #region Atualizar Views
            AtualizarViews();
            #endregion
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroDeClientesForm TelaCadastroCliente = new CadastroDeClientesForm();
            TelaCadastroCliente.ShowDialog();
            AtualizarTelaClientes();
        }

        private void btnCadastroDeFuncionarios_Click(object sender, EventArgs e)
        {
            CadastroDeFuncionariosForm TelaCadastroFuncionario = new CadastroDeFuncionariosForm();
            TelaCadastroFuncionario.ShowDialog();
            AtualizarTelaFuncionario();
        }

        private void btnCadastroDeSabores_Click(object sender, EventArgs e)
        {
            CadastroDeSaboresForm TelaCadastroFuncionario = new CadastroDeSaboresForm();
            TelaCadastroFuncionario.ShowDialog();
            AtualizarTelaSabores();
        }

        private void btnCadastroDeIngredientes_Click(object sender, EventArgs e)
        {
            CadastroDeIngredientesForm TelaCadastroIngrediente = new CadastroDeIngredientesForm();
            TelaCadastroIngrediente.ShowDialog();
            AtualizarTelaIngredientes();
        }

        private void btnCadastroValores_Click(object sender, EventArgs e)
        {
            CadastroDeValorForm TelaCadastroValores = new CadastroDeValorForm();
            TelaCadastroValores.ShowDialog();
            AtualizarTelaValores();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastroDeProdutosForm TelaCadastroProduto = new CadastroDeProdutosForm();
            TelaCadastroProduto.ShowDialog();
            AtualizarTelaProdutos();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }

        private void Configura��esBtn_Click(object sender, EventArgs e)
        {
            TelaConfigura��oForm telaConfigura��o = new TelaConfigura��oForm();
            telaConfigura��o.ShowDialog();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                TelaFechamentoPrincipal telaFechamento = new TelaFechamentoPrincipal();
                DialogResult resultado = telaFechamento.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else if (resultado == DialogResult.Cancel)
                {

                }
                else if (resultado == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    notifyIconSystemTray.ShowBalloonTip(1000);
                }
            }

        }

        private void TelaPrincipalForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
        }

        private void abrirAplica��oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Atualizar Telas
        private void AtualizarViews()
        {
            AtualizarTelaIngredientes();
            AtualizarTelaEndereco();
            AtualizarTelaClientes();
            AtualizarTelaFuncionario();
            AtualizarTelaSabores();
            AtualizarTelaValores();
            AtualizarTelaProdutos();
        }

        private void AtualizarTelaProdutos()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var produto = new Produto();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
                DataTable linhas = produtoDAO.Buscar(produto);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewProdutos.Columns.Clear();
                dataGridViewProdutos.AutoGenerateColumns = true;
                dataGridViewProdutos.DataSource = linhas;
                dataGridViewProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaValores()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var valor = new Valor();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
                DataTable linhas = valorDAO.Buscar(valor);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewValores.Columns.Clear();
                dataGridViewValores.AutoGenerateColumns = true;
                dataGridViewValores.DataSource = linhas;
                dataGridViewValores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaSabores()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewSabores.Columns.Clear();
                dataGridViewSabores.AutoGenerateColumns = true;
                dataGridViewSabores.DataSource = linhas;
                dataGridViewSabores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaFuncionario()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var funcionario = new Funcionario();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewFuncionario.Columns.Clear();
                dataGridViewFuncionario.AutoGenerateColumns = true;
                dataGridViewFuncionario.DataSource = linhas;
                dataGridViewFuncionario.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaIngredientes()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var ingrediente = new Ingredientes();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewIngredientes.Columns.Clear();
                dataGridViewIngredientes.AutoGenerateColumns = true;
                dataGridViewIngredientes.DataSource = linhas;
                dataGridViewIngredientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaEndereco()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var endereco = new Endereco();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewEndereco.Columns.Clear();
                dataGridViewEndereco.AutoGenerateColumns = true;
                dataGridViewEndereco.DataSource = linhas;
                dataGridViewEndereco.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaClientes()
        {
            //Inst�ncia e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o m�todo para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewClientes.Columns.Clear();
                dataGridViewClientes.AutoGenerateColumns = true;
                dataGridViewClientes.DataSource = linhas;
                dataGridViewClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void tabControlCadastros_MouseClick(object sender, MouseEventArgs e)
        {

        }

        #region Cell Formating
        private void dataGridViewFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewFuncionario.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewFuncionario.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewFuncionario.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewFuncionario.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewFuncionario.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewFuncionario.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor num�rico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        private void dataGridViewClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewClientes.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }

            if (this.dataGridViewClientes.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewClientes.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewClientes.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewClientes.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor num�rico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }

        }

        private void dataGridViewEndereco_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewEndereco.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }

            if (this.dataGridViewEndereco.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }

        }

        private void dataGridViewSabores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewSabores.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }

            if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
        }

        private void dataGridViewValores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewValores.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }

            if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Tamanho"))
            {
                e.Value = EnumExtensions.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Valor") || this.dataGridViewValores.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
            {
                // formata valor num�rico com duas casa decimais
                double d = double.Parse(e.Value.ToString());

                e.Value = d.ToString("N2");
            }
        }

        private void dataGridViewProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewProdutos.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }

            if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Tipo Produto"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewProdutos.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor num�rico com duas casa decimais
                double d = double.Parse(e.Value.ToString());

                e.Value = d.ToString("N2");
            }
        }
        #endregion

        private void dataGridViewFuncionario_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewFuncionario.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewFuncionario.Rows[dataGridViewFuncionario.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                CadastroDeFuncionariosForm telaEditar = new CadastroDeFuncionariosForm(id);
                telaEditar.ShowDialog();
                AtualizarTelaFuncionario();
            }
        }

        private void btnIconExcluir_Click(object sender, EventArgs e)
        {

            if (dataGridViewFuncionario.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewFuncionario.Rows[dataGridViewFuncionario.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                try
                {
                    int idExclusao = id;
                    // chama o m�todo da model para excluir
                    funcionarioDAO.Excluir(id);
                    MessageBox.Show("Dados excluidos com sucesso! " + id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AtualizarTelaFuncionario();
            }


        }
    }
}