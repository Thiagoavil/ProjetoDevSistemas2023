using PizzariaDoZe_DAO.PastaIngredientes;
using PizzariaDoZe_DAO.PastaPizza;
using PizzariaDoZe_DAO.PastaProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO.PastaPedido
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPago { get; set; }
        public string FormaDePagamento { get; set; }
        public int FuncionarioId { get; set; }
        public int ClienteId { get; set; }  
        public List<Pizza> Pizzas { get; set; }
        public List<Produto> Produtos { get; set; }

        public Pedido(string descricao,decimal valor,decimal valorPago,string formaDePagamento,int funcionarioId,int clienteId, List<Pizza> pizzas = null, List<Produto> produtos = null) 
        {
            Descricao = descricao;
            Valor = valor;
            ValorPago = valorPago;
            FormaDePagamento = formaDePagamento;
            FuncionarioId = funcionarioId;
            ClienteId = clienteId;
            this.Pizzas = pizzas;
            this.Produtos = produtos;

        }
    }
}
