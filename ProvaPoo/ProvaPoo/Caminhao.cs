using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPoo
{
    internal class Caminhao : Veiculo
    {
        int eixos;

        public int Eixos { get => eixos; set => eixos = value; }

        public Caminhao(string placa, int ano, int _eixos) : base(placa, ano)
        {
            this.eixos = _eixos;
        }

        public override double Alugar()
        {
            int anoAtual = DateTime.Now.Year;
            int anoVeiculo = Ano;
            double diaria = (300 * eixos) - (anoAtual - anoVeiculo) * 50;
            if (diaria < 0)
                diaria = 0;
            return diaria;
        }
        public override void Relatorio()
        {
            Console.WriteLine($"[Caminhão] Placa: {Placa}, Ano: {Ano}, Eixos: {Eixos}, Aluguel Diário: R${Alugar():F2}");
        }
    }
}
