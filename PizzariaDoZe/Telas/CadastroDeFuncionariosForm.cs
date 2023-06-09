﻿using PizzariaDoZe_DAO.PastaEndereco;
using PizzariaDoZe_DAO.PastaFuncionario;
using System.Security.Cryptography;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe.Telas
{
    public partial class CadastroDeFuncionariosForm : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;


        public CadastroDeFuncionariosForm()
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
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
        }

        public CadastroDeFuncionariosForm(int id)
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
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
            AtualizaTelaEditar(id);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
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

        /// string hash = ClassFuncoes.Sha256Hash(textBoxSenha.Text);
        public static string Sha256Hash(string senha)
        {
            // Create a new Stringbuilder to collect the bytes and create a string.
            var hash = new StringBuilder();
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    hash.Append(data[i].ToString("x2"));
                }
            }
            // retorna o hash SHA256.
            return hash.ToString();
        }

        private void CadastroDeFuncionariosForm_FormClosing(object sender, FormClosingEventArgs e)
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
            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = txtNome.Text,
                Cpf = maskedTextBoxCpf.Text,
                Matricula = txtMatricula.Text,
                Senha = Sha256Hash(txtSenha.Text),
                Grupo = (radioButtonGrupoAdmin.Checked) ? '1' : (radioButtonGrupoAtendente.Checked) ? '2' : '3',
                Motorista = TxtCnh.Text,
                Validade = DatePickerValidadeCNH.Value,
                Observacao = txtObservacoes.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = txtEmail.Text,
                EnderecoId = int.Parse(txtId.Text),
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    IdFuncionario.Text = row[0].ToString();
                    txtNome.Text = row[1].ToString();
                    maskedTextBoxCpf.Text = row[2].ToString();
                    txtMatricula.Text = row[3].ToString();
                    txtSenha.Text = row[4].ToString();
                    if (row[5].ToString().Equals("1"))
                    {
                        radioButtonGrupoAdmin.Checked = true;
                    }
                    else if (row[5].ToString().Equals("2"))
                    {
                        radioButtonGrupoAtendente.Checked = true;
                    }
                    else
                    {
                        radioButtonGrupoEntregador.Checked = true;
                    }
                    TxtCnh.Text = row[6].ToString();
                    DatePickerValidadeCNH.Text = row[7].ToString();
                    txtObservacoes.Text = row[8].ToString();
                    maskedTextBoxTelefone.Text = row[9].ToString();
                    txtEmail.Text = row[10].ToString();
                    txtId.Text = row[11].ToString();
                    maskedTextBoxCep.Text = row[12].ToString();
                    txtLogradouro.Text = row[13].ToString();
                    txtBairro.Text = row[14].ToString();
                    txtCidade.Text = row[16].ToString();
                    comboBoxUf.Text = row[18].ToString();
                    txtPais.Text = row[20].ToString();
                    txtNumero.Text = row[21].ToString();
                    txtComplemento.Text = row[22].ToString();
                }
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtObservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelObservações_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length <= 0 || txtId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Cpf = maskedTextBoxCpf.Text,
                Matricula = txtMatricula.Text,
                Senha = Sha256Hash(txtSenha.Text),
                Grupo = (radioButtonGrupoAdmin.Checked) ? '1' : (radioButtonGrupoAtendente.Checked) ? '2' : '3',
                Motorista = TxtCnh.Text,
                Validade = DatePickerValidadeCNH.Value,
                Observacao = txtObservacoes.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = txtEmail.Text,
                EnderecoId = int.Parse(txtId.Text),
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
            };
            try
            {
                // chama o método da model para editar
                funcionarioDAO.Editar(funcionario);
                MessageBox.Show("Dados editados com sucesso! " + txtId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
