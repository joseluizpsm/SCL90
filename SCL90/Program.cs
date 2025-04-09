// Remover depois
List<int> listaDasRespostas = new List<int>();
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██╗░░░░░░█████╗░░█████╗░
██╔════╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
╚█████╗░██║░░╚═╝██║░░░░░╚██████║██║░░██║
░╚═══██╗██║░░██╗██║░░░░░░╚═══██║██║░░██║
██████╔╝╚█████╔╝███████╗░█████╔╝╚█████╔╝
╚═════╝░░╚════╝░╚══════╝░╚════╝░░╚════╝░");
}
void ExibirOpcoesDoMenu()
{
    Console.WriteLine(ExibirLogo);
    Console.WriteLine("\nDigite 1 para iniciar o questionário");
    Console.WriteLine("\nDigite 2 para sair");

    Console.Write("\nDigite a sua opção:");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            IniciarPrograma();
            break;
        case 2:
            Console.WriteLine("Bye Bye :D");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
//
void IniciarPrograma()
{
    Console.Clear();
    ExibirLogo();
    Thread.Sleep(2000);
    Console.WriteLine("Iniciando o questionário");
    ProximaPergunta();
}
//
void ExibirPergunta()
{
    string pergunta
}
//
void ProximaPergunta()
{
    Console.Clear();
    int numPergunta = 0;
    ExibirPergunta();
}
ExibirLogo();
ExibirOpcoesDoMenu();