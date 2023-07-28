var MensagemDeBoasVindas = "Bem vindos ao Screen Sound!";
var ListaDasBandasResgistradas = new Dictionary<string, List<int>>();

void ExibirLogoDoPrograma()
{
     Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(" ");
    Console.WriteLine(MensagemDeBoasVindas + "\n");
}

void ExibirMenu()
{
  Console.Clear();
  ExibirLogoDoPrograma();
  Console.WriteLine("Escolha uma das opções abaixo: ");
  Console.WriteLine("1  -> Registrar uma banda!");
  Console.WriteLine("2  -> Exibir todas as bandas já registradas!");
  Console.WriteLine("3  -> Avaliar uma banda !");
  Console.WriteLine("4  -> Visualizar a média de avaliação de uma banda!");
  Console.WriteLine("-1 -> Sair \n");
  Console.Write("Digite sua opção: ");
  var OpçãoEscolhida = int.Parse(Console.ReadLine()!);
  switch (OpçãoEscolhida)
    {
        case 1: RegistrarBandas();
            break;
        case 2: ExibirBandasRegistradas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4:ExibicaoDasMediasDasNotasDeUmaBanda();
            break;
        case -1: Console.WriteLine("Tchau Tchau, muito obrigado por utilizar o Screen Sound :)");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void ExibirOpcao(string mensagem)
{
    for (int i =0; i <= mensagem.Length; i++)
    {
        Console.Write('*');
    }
    Console.WriteLine("\n " + mensagem);
    for (int i = 0; i <= mensagem.Length; i++)
    {
        Console.Write('*');
    }
    Console.WriteLine(" ");
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirOpcao("Registro de bandas!\n");
    Console.Write("Digite uma banda para que possa ser registrada: ");
    var Banda = Console.ReadLine()!;
    ListaDasBandasResgistradas.Add(Banda, new List<int>());
    Console.WriteLine(" ");
    Console.Write($"A banda {Banda} foi adicionada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirOpcao("Bandas registradas");
    Console.WriteLine(" ");
    foreach (string banda in ListaDasBandasResgistradas.Keys)
    {
        Console.WriteLine(banda);
    }
    Thread.Sleep(3000);
    Console.Clear();
    ExibirMenu();
}

void AvaliarBandas()
{
    Console.Clear();
    ExibirOpcao("Avaliação de bandas!");
    Console.WriteLine(" ");
    Console.Write("Qual banda você quer avaliar: ");
    var BandaQueSeraAvaliada = Console.ReadLine()!;
    if (ListaDasBandasResgistradas.ContainsKey(BandaQueSeraAvaliada))
    {
        Console.WriteLine(" ");
        Console.Write($"Qual nota você acha que {BandaQueSeraAvaliada} merece? ");
        var NotaAtribuidaABanda = int.Parse(Console.ReadLine());
        ListaDasBandasResgistradas[BandaQueSeraAvaliada].Add(NotaAtribuidaABanda);
        Console.WriteLine($"A nota {NotaAtribuidaABanda} foi atribuída com sucesso a banda {BandaQueSeraAvaliada}!");
        Thread.Sleep(3500);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine("Banda não encontrada!");
        Thread.Sleep(2500);
        Console.Clear();
        ExibirMenu();
    }
}

void ExibicaoDasMediasDasNotasDeUmaBanda()
{
    Console.Clear();
    ExibirOpcao("Visualize a média das notas de uma banda!");
    Console.WriteLine(" ");
    Console.Write("De qual banda você gostaria de ver a média das notas? ");
    var BandaSeraExibidaAMedia = Console.ReadLine()!;
    if (ListaDasBandasResgistradas.ContainsKey(BandaSeraExibidaAMedia))
    {
        List<int> NotaDasBandas = ListaDasBandasResgistradas[BandaSeraExibidaAMedia];
        Console.WriteLine($"\nA média da banda {BandaSeraExibidaAMedia} é {NotaDasBandas.Average().ToString("F2")}  ");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"Banda {BandaSeraExibidaAMedia} não foi encontrada!");
        Thread.Sleep(2500);
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMenu();




