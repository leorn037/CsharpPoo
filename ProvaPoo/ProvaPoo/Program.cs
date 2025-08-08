using ProvaPoo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        string? entrada;

        Console.WriteLine("=== Cadastro de Ônibus ===");

        int qtdOnibus;
        do
        {
            Console.Write("Quantos ônibus deseja cadastrar? (mínimo 2): ");
            entrada = Console.ReadLine();
        } while (!int.TryParse(entrada, out qtdOnibus));
        if (qtdOnibus < 2)
        {
            qtdOnibus = 2;
            Console.WriteLine("Definido para o mínimo de 2");
        }
            

        for (int i = 0; i < qtdOnibus; i++)
        {
            Console.WriteLine($"\nÔnibus #{i + 1}:");

            string? placa;
            do
            {
                Console.Write("Placa: ");
                placa = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(placa));

            int ano;
            do
            {
                Console.Write("Ano do Veículo: ");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out ano));

            int assentos;
            do
            {
                Console.Write("Número de assentos: ");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out assentos));

            veiculos.Add(new Onibus(placa, ano, assentos));
        }

        Console.WriteLine("\n=== Cadastro de Caminhões ===");

        int qtdCaminhao;
        do
        {
            Console.Write("Quantos caminhões deseja cadastrar? (mínimo 2): ");
            entrada = Console.ReadLine();
        } while (!int.TryParse(entrada, out qtdCaminhao));
        if (qtdCaminhao < 2)
        {
            qtdCaminhao = 2;
            Console.WriteLine("Definido para o mínimo de 2");
        }

            for (int i = 0; i < qtdCaminhao; i++)
        {
            Console.WriteLine($"\nCaminhão #{i + 1}:");

            string? placa;
            do
            {
                Console.Write("Placa: ");
                placa = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(placa));

            int ano;
            do
            {
                Console.Write("Ano do Veículo: ");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out ano));

            int eixos;
            do
            {
                Console.Write("Número de eixos: ");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out eixos));

            veiculos.Add(new Caminhao(placa, ano, eixos));
        }

        Console.WriteLine("\n--- Relatório de Aluguel Diário ---");
        foreach (var veiculo in veiculos)
        {
            veiculo.Relatorio();
        }
    }
}