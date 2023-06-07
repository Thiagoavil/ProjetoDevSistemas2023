using PizzariaDoZe.PastaEnums;
using PizzariaDoZe.Properties;
using PizzariaDoZe_DAO.PastaCliente;
using PizzariaDoZe_DAO.PastaEndereco;
using PizzariaDoZe_DAO.PastaFuncionario;
using PizzariaDoZe_DAO.PastaIngredientes;
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
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastroDeProdutosForm TelaCadastroProduto = new CadastroDeProdutosForm();
            TelaCadastroProduto.ShowDialog();
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

        private void AtualizarViews()
        {
            AtualizarTelaIngredientes();
            AtualizarTelaEndereco();
            AtualizarTelaClientes();
            AtualizarTelaFuncionario();
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

        private void tabControlCadastros_MouseClick(object sender, MouseEventArgs e)
        {

        }

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
    }
}