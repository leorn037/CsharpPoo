using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal class Fornecedor
    {
        // Atributos (propriedades)
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Cnpj { get; set; }

        // Construtor
        public Fornecedor(string nome, string contato, string cnpj)
        {
            this.Nome = nome;
            this.Contato = contato;
            this.Cnpj = cnpj;
        }
    }
}
