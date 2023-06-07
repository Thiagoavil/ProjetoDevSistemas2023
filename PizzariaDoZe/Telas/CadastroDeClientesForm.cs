using PizzariaDoZe_DAO.PastaCliente;
using PizzariaDoZe_DAO.PastaEndereco;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe.Telas
{
    public partial class CadastroDeClientesForm : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;
        public CadastroDeClientesForm()
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
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }

            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = txtNome.Text,
                Cpf = maskedTextBoxCpf.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = txtEmail.Text,
                EnderecoId = int.Parse(txtId.Text),
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroDeClientesForm_Load(object sender, EventArgs e)
        {
        }

        private void labelCpf_Click(object sender, EventArgs e)
        {
        }

        private void CadastroDeClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void labelRua_Click(object sender, EventArgs e)
        {

        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelTelefone_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCep.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = maskedTextBoxCep.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela

                //userControlEndereco.maskedTextBoxCep.Text = "";
                txtId.Text = "";
                txtLogradouro.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                comboBoxUf.Text = "";
                txtPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    txtId.Text = row["id"].ToString();
                    maskedTextBoxCep.Text = row["cep"].ToString(); ;
                    txtLogradouro.Text = row["logradouro"].ToString(); ;
                    txtBairro.Text = row["bairro"].ToString(); ;
                    txtCidade.Text = row["cidade"].ToString(); ;
                    comboBoxUf.Text = row["uf"].ToString(); ;
                    txtPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUf_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
