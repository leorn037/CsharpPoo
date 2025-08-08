using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPoo
{
    internal abstract class Veiculo
    {
        string placa;
        int ano;

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        protected Veiculo(string _placa, int ano)
        {
            this.placa = _placa;
            this.ano = ano;
        }

        public abstract double Alugar();

        public abstract void Relatorio();
    }
}

