using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPoo
{
    internal class Onibus : Veiculo
    {
        int assentos;

        public int Assentos { get => assentos; set => assentos = value; }

        public Onibus(string placa, int ano, int _assentos) : base(placa, ano)
        {
            this.assentos = _assentos;
        }

        public override double Alugar()
        {
            int anoAtual = DateTime.Now.Year;
            int anoVeiculo = Ano;
            double diaria = (30 * assentos) - (anoAtual - anoVeiculo) * 70;
            if (diaria < 0)
                diaria = 0;
            return diaria;
        }

        public override void Relatorio()
        {
            Console.WriteLine($"[Ônibus] Placa: {Placa}, Ano: {Ano}, Assentos: {Assentos}, Aluguel Diário: R${Alugar():F2}");
        }

    }
}

