using PizzariaDoZe_DAO.PastaPedido;
using PizzariaDoZe_DAO.PastaPizza;
using PizzariaDoZe_DAO.PastaProduto;
using PizzariaDoZe_DAO.PastaSabores;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoriaDoZe_DAO.PastaPedido
{
    public class PedidoDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public PedidoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)

            var descricao = comando.CreateParameter();
            descricao.ParameterName = "@descricao";
            descricao.Value = pedido.Descricao;
            comando.Parameters.Add(descricao);

            var valor = comando.CreateParameter();
            valor.ParameterName = "@valor";
            valor.Value = pedido.Valor;
            comando.Parameters.Add(valor);

            var valorPago = comando.CreateParameter();
            valorPago.ParameterName = "@valorPago";
            valorPago.Value = pedido.ValorPago;
            comando.Parameters.Add(valorPago);

            var formaDePagamento = comando.CreateParameter();
            formaDePagamento.ParameterName = "@formaDePagamento";
            formaDePagamento.Value = pedido.FormaDePagamento;
            comando.Parameters.Add(formaDePagamento);

            var funcionarioId = comando.CreateParameter();
            funcionarioId.ParameterName = "@funcionarioId";
            funcionarioId.Value = pedido.FuncionarioId;
            comando.Parameters.Add(funcionarioId);

            var clienteId = comando.CreateParameter();
            clienteId.ParameterName = "@clienteId";
            clienteId.Value = pedido.ClienteId;
            comando.Parameters.Add(clienteId);

            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
                string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
                //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
                comando.CommandText = @"INSERT INTO tb_pedido (valor, descricao, tipo,funcionarioId)
                VALUES (@valor, @descricao, @tipo,@funcionarioId);" + auxSQL_ID;
                //executa o comando no banco de dados e captura o ID gerado
                var IdpedidoGerado = comando.ExecuteScalar();
                // realiza um loop para pegar todos os ingredientes selecionados
                foreach (Pizza auxPizza in pedido.Pizzas)
                {
                    // salvar os ingredientes do pedido
                    comando.CommandText = @"INSERT INTO Pizza_Pedidos(id_Pedido,id_Pizza ) VALUES (" + Convert.ToInt32(IdpedidoGerado) + "," + auxPizza.IdPizza + ")";
                    //Executa o script na conexão e retorna o número de linhas afetadas.
                    var linhasRecebimentoComanda = comando.ExecuteNonQuery();
                }

                foreach (Produto auxProduto in pedido.Produtos)
                {
                    // salvar os ingredientes do pedido
                    comando.CommandText = @"INSERT INTO itens_Pedido(id_item,id_Pedido ) VALUES (" + auxProduto.Id + "," + Convert.ToInt32(IdpedidoGerado) + ")";
                    //Executa o script na conexão e retorna o número de linhas afetadas.
                    var linhasRecebimentoComanda = comando.ExecuteNonQuery();
                }
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
                return Convert.ToInt32(IdpedidoGerado);
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }
    }
}
