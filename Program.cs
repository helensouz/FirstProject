// Screen sound


//list empty was created.
//  List<string> listaDasBandas = new List<string>();

// List<string> listaDasBandas = new List<string> { "Bad omens ", "Sleep sirens", "Simple plan" };

using System;

Dictionary<string, List<int>> BandasDicionario = new Dictionary<string, List<int>>(); // We´re creating a new empty dicionary
BandasDicionario.Add("Linkin park", new List<int> { 10, 8, 9 });
BandasDicionario.Add("Legiao urbana", new List<int>());


void ExibirMensagem()
{
    string curso = "\r\n░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░\r\n██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗\r\n╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║\r\n░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║\r\n██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝\r\n╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

    Console.WriteLine(curso);
}



void ExibirOpcoesMenu()
{


    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaInt)
    {
        case 1: Console.WriteLine("Voce escolheu a opcao: " +  opcaoEscolhida);
            break;
        case 2: MostrarBandasRegistradas(); 
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MediaBandas();
            break;
      

            default: Console.WriteLine("opcao invalida");
            break;
    }

}
ExibirOpcoesMenu();


void ExibirTituloDaOpcao(string titulo)
{
    int qtDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}





void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar:  ");


    string nomeDaBanda = Console.ReadLine()!; // ! indica que nao queremos trabalhar com valor nulo
    BandasDicionario.Add(nomeDaBanda, new List<int>());
    Console.WriteLine( $"{nomeDaBanda} foi registrada com sucesso ");
    Thread.Sleep(200);
    Console.Clear();
    ExibirOpcoesMenu();

}


void AvaliarBanda()
{
    //digite a banda que quer avaliar
    // se a banda existir, adicionar uma nova nota
    //senao, voltar ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(BandasDicionario.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece:  ");
        int nota = int.Parse(Console.ReadLine()!);
        BandasDicionario[nomeDaBanda].Add(nota);
        Console.WriteLine("Nota adicionada");
        Thread.Sleep(200);
        Console.Clear();
        ExibirOpcoesMenu(); 

    } else
    {
        Console.WriteLine($"A banda {nomeDaBanda} nao foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        ExibirOpcoesMenu();
        Console.ReadKey();
        Console.Clear();
    }

}


//funcao 
//peguntar qual a banda que queremos ver a media
//verificar se a banda esta presente
//senao calcular a media

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    

   /* for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda : {listaDasBandas[i]}");
    } */

    foreach (string banda in BandasDicionario.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    ExibirTituloDaOpcao("Digite alguma tecla para voltar ao menu anterior");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
       
}



void MediaBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir media da banda");
    ExibirTituloDaOpcao("Digite banda voce gostaria de ver a média:  ");
    string nomeDaBanda = Console.ReadLine()! ;

    if (BandasDicionario.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = BandasDicionario[nomeDaBanda];
        Console.WriteLine(notasDaBanda.Average());
       
    }
    else
    { Console.WriteLine("essa banda nao existe");
    }
    ExibirTituloDaOpcao("Digite alguma tecla para voltar ao menu anterior");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}





RegistrarBanda();
MostrarBandasRegistradas();














/*
Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
Criar um programa que gerencie o estoque de uma loja. 
Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
Crie um programa que implemente um quiz simples de perguntas e respostas.
Utilize um dicionário para armazenar as perguntas e as respostas corretas.
Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

*/