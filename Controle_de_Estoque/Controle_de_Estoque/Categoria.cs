using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal class Categoria
    {
        // Atributos (propriedades)
        public string Nome { get; set; }
        public string Descricao { get; set; }

        // Construtor
        public Categoria(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }
    }
}
