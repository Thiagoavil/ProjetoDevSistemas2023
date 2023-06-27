using PizzariaDoZe_DAO.PastaIngredientes;
using PizzariaDoZe_DAO.Pastapizzaes;
using PizzariaDoZe_DAO.PastaSabores;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO.PastaPizza
{
    public class PizzaDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public PizzaDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Pizza pizza)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var valor = comando.CreateParameter(); 
            valor.ParameterName = "@valor"; 
            valor.Value = pizza.Valor; 
            comando.Parameters.Add(valor);

            var tamanho = comando.CreateParameter(); 
            tamanho.ParameterName = "@tamanho"; 
            tamanho.Value = pizza.Tamanho; 
            comando.Parameters.Add(tamanho);

            var tipo = comando.CreateParameter();
            tipo.ParameterName = "@tipo";
            tipo.Value = pizza.Tipo;
            comando.Parameters.Add(tipo);

            var borda = comando.CreateParameter();
            borda.ParameterName = "@borda";
            borda.Value = pizza.Borda;
            comando.Parameters.Add(borda);

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
                comando.CommandText = @"INSERT INTO tb_Pizza (valor, tamanho, tipo,Borda)
                VALUES (@valor, @tamanho, @tipo,@borda);" + auxSQL_ID;
                //executa o comando no banco de dados e captura o ID gerado
                var IdpizzaGerado = comando.ExecuteScalar();
                // realiza um loop para pegar todos os ingredientes selecionados
                foreach (Sabor auxSabor in pizza.Sabores)
                {
                    // salvar os ingredientes do pizza
                    comando.CommandText = @"INSERT INTO sabores_pizza(pizza_id,sabor_id ) VALUES (" + Convert.ToInt32(IdpizzaGerado) + "," + auxSabor.Id + ")";
                    //Executa o script na conexão e retorna o número de linhas afetadas.
                    var linhasRecebimentoComanda = comando.ExecuteNonQuery();
                }
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
                return Convert.ToInt32(IdpizzaGerado);
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
