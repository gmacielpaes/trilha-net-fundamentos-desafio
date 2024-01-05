using System.Text.RegularExpressions;

namespace Projeto_Estacionamento.Models
{
    // A classe representa um estacionamento com funcionalidades básicas.
    public class Estacionamento
    {
        // Construtor que inicializa os preços iniciais do estacionamento.
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Variáveis privadas para armazenar os preços do estacionamento.
        private decimal precoInicial;
        private decimal precoPorHora;

        // Lista para armazenar as placas dos veículos no estacionamento.
        List<string> veiculos = new List<string>();

        // Método privado para validar o formato da placa de um veículo.
        private bool ValidarPlaca(string placa)
        {
            string padrao = @"^[A-Z]{3}-[0-9]{4}$";
            RegexOptions options = RegexOptions.IgnoreCase;
            return Regex.IsMatch(placa, padrao, options);
        }

        // Método público para adicionar um veículo ao estacionamento.
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a adicionar no estacionamento: ");
            string placa = Console.ReadLine();
            if (ValidarPlaca(placa))
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Veículo adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("A placa do veículo está no formato incorreto.");
            }
        }

        // Método público para remover um veículo do estacionamento.
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a remover do estacionamento: ");
            string placa = Console.ReadLine().ToUpper();
            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Quanto tempo o veículo ficou no estacionamento (em minutos)?: ");
                decimal tempo = Convert.ToDecimal(Console.ReadLine());
                veiculos.Remove(placa); 
                decimal precoFinal = precoInicial + (precoPorHora * tempo);
                Console.WriteLine($"Veículo removido do estacionamento. O valor a pagar é de: {precoFinal:C}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        // Método público para listar os veículos no estacionamento.
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos no estacionamento:");
                foreach (var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos no estacionamento.");
            }
        }
    }
}
