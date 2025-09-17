using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal class Produto
    {
        // Atributos (propriedades)
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int IdFornecedor { get; set; }
        public int IdCategoria { get; set; }

        // Construtor
        public Produto(string nome, int quantidade, decimal precoUnitario, int idFornecedor, int idCategoria)
        {
            this.Nome = nome;
            this.Quantidade = quantidade;
            this.PrecoUnitario = precoUnitario;
            this.IdFornecedor = idFornecedor;
            this.IdCategoria = idCategoria;
        }
    }
}
