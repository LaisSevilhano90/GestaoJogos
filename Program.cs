// Program => services => repositories => dados(DB)

using GestaoJogos.Models;
using GestaoJogos.Repositories;
using GestaoJogos.Services;

var repository = new JogoRepository();
var service = new JogoService(repository);

bool executando = true;

while (executando)
{
    Console.Clear();
    Console.WriteLine("========= Gestão de Jogos =============");
    Console.WriteLine("1 - CADASTRAR JOGO");
    Console.WriteLine("2 - LISTAR JOGO");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("\nEscolha uma opção: ");

    string? opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
            //Cadastrar();
            break;

            case "2":
            Listar();
            break;

            case "0":
            executando = false;
            break;

            default:
            Console.WriteLine("Opção inválida");
            Pausar();
            break;
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"\nErro: {ex:Message}");
        throw;
    }
}

void Listar()
{
    Console.Clear();
    Console.WriteLine("======== Jogos Cadastrados ===========");
    
    var jogos = service.Listar();

    if(jogos.Count == 0)
    {
        Console.WriteLine("Nenhum jogo cadastrado");
    }
    else
    {
        foreach (var jogo in jogos)
        {
            ExibirJogo(jogo);
        }
    }

    Pausar();
}

void ExibirJogo(Jogo jogo)
{
    Console.WriteLine($"""
    ---------------------
    ID: {jogo.ID}
    Nome: {jogo.Nome}
    Desenvolvedora: {jogo.Desenvolvedora}
    Ano de Lançamento : {jogo.AnoLancamento}
    Preço: {jogo.Preco}
    """);
}

void Pausar()
{
    Console.WriteLine("\nPressione ENTER para continuar");
    Console.ReadLine();
}