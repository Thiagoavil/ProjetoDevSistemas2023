using PizzariaDoZe.PastaEnums;
using PizzariaDoZe_DAO.PastaProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas
{
    public partial class CadastroDeProdutosForm : Form
    {
        private ProdutoDAO produtoDAO;

        public CadastroDeProdutosForm()
        {
            InitializeComponent();
            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo
            //resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser
            //automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
            #region Configuração De Botões no Foco
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            #endregion
            #region Enter Como Tab
            //Evento em Funcoes que congifura a tecla enter como o tab
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            #endregion
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);
            CarregaEnumListBox();
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            ListTipo.Items.Clear();
            ListTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CadastroDeProdutosForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = txtNome.Text,
                Valor = decimal.Parse(maskedTextBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), ListTipo.Text),
                ML = listBox1.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
