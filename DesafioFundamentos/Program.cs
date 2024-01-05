using Projeto_Estacionamento.Models;

// Variáveis para armazenar os preços iniciais do estacionamento.
decimal precoInicial = 0;
decimal precoPorHora = 0;

// Solicita ao usuário os preços iniciais do estacionamento.
Console.WriteLine("Bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial em reais:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora em reais:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Cria uma instância da classe Estacionamento com os preços informados.
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

// Verificação do preço inicial e do preço por hora. Preços não devem ser menores ou iguais a zero.
if (precoInicial > 0 && precoPorHora > 0)
{
// Loop principal para o menu de opções.
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Menu de opções:\n");
        Console.WriteLine("1 - Adicionar Veículo");
        Console.WriteLine("2 - Remover Veículo");
        Console.WriteLine("3 - Listar Veículos");
        Console.WriteLine("4 - Encerrar");
        Console.WriteLine("----------------------\nDigite a opção desejada:");

        // Switch para tratar as opções do menu.
        switch (Console.ReadLine())
        {
            case "1":
                estacionamento.AdicionarVeiculo();
                break;
            case "2":
                estacionamento.RemoverVeiculo();
                break;
            case "3":
                estacionamento.ListarVeiculos();
                break;
            case "4":
                Console.WriteLine("Encerrando o programa.");
                return;
            default:
                Console.WriteLine("Opção Inválida.");
                break;
        }
        Console.WriteLine("Digite qualquer tecla para retornar.");
        Console.ReadLine();
    }
}
else
{
    Console.WriteLine("Preços Inválidos. Encerrando o programa.");
}