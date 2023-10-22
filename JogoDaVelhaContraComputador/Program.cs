const string condicaoBolinhaVencedor = "OOO";
const string condicaoXisVencedor = "XXX";

//Menu inicial
Console.Clear();
Console.WriteLine("==========BEM VINDO AO JOGO DA VELHA CONTRA O COMPUTADOR!!==========");
Console.WriteLine("\n\nPRESSIONE QUALQUER TECLA PARA COMEÇAR");
Console.ReadKey();

while (true)
{
    string[,] matrizJogo = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

    string simboloJogador, resultadoFinal;
    int trocaJogador = 1; //Bolinha sempre começa

    bool bolinhaVencedor = false, xisVencedor = false;

    int rodada = 1;


    Console.Clear();
    Console.WriteLine("DIGITE O NÚMERO DA POSIÇÃO NA QUAL DESEJA EFETUAR SUA JOGADA QUANDO SOLICITADO\n");
    Console.WriteLine($" 1 | 2 | 3");
    Console.WriteLine($"-----------");
    Console.WriteLine($" 4 | 5 | 6");
    Console.WriteLine($"-----------");
    Console.WriteLine($" 7 | 8 | 9\n");
    Console.ReadKey();
    while (rodada <= 9)
    {
        simboloJogador = trocaJogador == 1 ? "O" : "X";

        int linhaJogada = 0, colunaJogada = 0;

        int numeroDaJogadaComputador = new Random().Next(1, 10);

        if (simboloJogador == "O")
        {

            switch (numeroDaJogadaComputador)
            {
                case 1:
                    linhaJogada = 0;
                    colunaJogada = 0;
                    break;
                case 2:
                    linhaJogada = 0;
                    colunaJogada = 1;
                    break;
                case 3:
                    linhaJogada = 0;
                    colunaJogada = 2;
                    break;
                case 4:
                    linhaJogada = 1;
                    colunaJogada = 0;
                    break;
                case 5:
                    linhaJogada = 1;
                    colunaJogada = 1;
                    break;
                case 6:
                    linhaJogada = 1;
                    colunaJogada = 2;
                    break;
                case 7:
                    linhaJogada = 2;
                    colunaJogada = 0;
                    break;
                case 8:
                    linhaJogada = 2;
                    colunaJogada = 1;
                    break;
                case 9:
                    linhaJogada = 2;
                    colunaJogada = 2;
                    break;
                default:
                    linhaJogada = 0;
                    colunaJogada = 0;
                    break;
            }

            if (matrizJogo[linhaJogada, colunaJogada] != " ")
            {
                continue;
            }

            
        }

        

        else if (simboloJogador == "X")
        {
            
            
            Console.WriteLine("Sua peça -> X");
            Console.Write("Digite a posição da sua jogada: ");
            _ = int.TryParse(Console.ReadLine(), out int posicaoDaJogadaUsuario);
            
            switch (posicaoDaJogadaUsuario)
            {
                case 1:
                    linhaJogada = 0;
                    colunaJogada = 0;
                    break;
                case 2:
                    linhaJogada = 0;
                    colunaJogada = 1;
                    break;
                case 3:
                    linhaJogada = 0;
                    colunaJogada = 2;
                    break;
                case 4:
                    linhaJogada = 1;
                    colunaJogada = 0;
                    break;
                case 5:
                    linhaJogada = 1;
                    colunaJogada = 1;
                    break;
                case 6:
                    linhaJogada = 1;
                    colunaJogada = 2;
                    break;
                case 7:
                    linhaJogada = 2;
                    colunaJogada = 0;
                    break;
                case 8:
                    linhaJogada = 2;
                    colunaJogada = 1;
                    break;
                case 9:
                    linhaJogada = 2;
                    colunaJogada = 2;
                    break;
                default:
                    Console.WriteLine("\nVocê digitou algo inválido. Tente novamente!");
                    continue;
            }
            if (matrizJogo[linhaJogada, colunaJogada] != " ")
            {
                Console.WriteLine("\nA posição já está ocupada. Tente novamente!");
                continue;
            }

        }

        

        matrizJogo[linhaJogada, colunaJogada] = simboloJogador;
        rodada++;


        Console.Clear();
        Console.WriteLine($"Computador jogou na posição {numeroDaJogadaComputador}\n");
        Console.WriteLine($"\n {matrizJogo[0, 0]} | {matrizJogo[0, 1]} | {matrizJogo[0, 2]}");
        Console.WriteLine($"-----------");
        Console.WriteLine($" {matrizJogo[1, 0]} | {matrizJogo[1, 1]} | {matrizJogo[1, 2]}");
        Console.WriteLine($"-----------");
        Console.WriteLine($" {matrizJogo[2, 0]} | {matrizJogo[2, 1]} | {matrizJogo[2, 2]}\n");

        for (int i = 0; i < 3; i++)
        {
            if (bolinhaVencedor || xisVencedor)
            {
                break;
            }

            string testeLinha = matrizJogo[i, 0] + matrizJogo[i, 1] + matrizJogo[i, 2];

            if (testeLinha == condicaoBolinhaVencedor)
            {
                bolinhaVencedor = true;
            }

            if (testeLinha == condicaoXisVencedor)
            {
                xisVencedor = true;
            }

        }

        //Verificação de vitória por colunas
        for (int i = 0; i < 3; i++)
        {
            if (bolinhaVencedor || xisVencedor)
            {
                break;
            }

            string testeColuna = matrizJogo[0, i] + matrizJogo[1, i] + matrizJogo[2, i];

            if (testeColuna == condicaoBolinhaVencedor)
            {
                bolinhaVencedor = true;
            }

            if (testeColuna == condicaoXisVencedor)
            {
                xisVencedor = true;
            }
        }

        //Verificacao de vitória por diagonal principal
        string testeDiagonalPrincipal = matrizJogo[0, 0] + matrizJogo[1, 1] + matrizJogo[2, 2];
        if (testeDiagonalPrincipal == condicaoBolinhaVencedor)
        {
            bolinhaVencedor = true;
        }
        else if (testeDiagonalPrincipal == condicaoXisVencedor)
        {
            xisVencedor = true;
        }

        //Verificacao de vitória por diagonal secundaria
        string testeDiagonalSecundaria = matrizJogo[0, 2] + matrizJogo[1, 1] + matrizJogo[2, 0];
        if (testeDiagonalSecundaria == condicaoBolinhaVencedor)
        {
            bolinhaVencedor = true;
        }
        else if (testeDiagonalSecundaria == condicaoXisVencedor)
        {
            xisVencedor = true;
        }

        //Verificação de vencedor ou empate
        if (xisVencedor || bolinhaVencedor || rodada > 9)
        {
            Console.WriteLine("O jogo acabou!!");

            if (xisVencedor)
            {
                resultadoFinal = "Jogador X venceu!";
            }
            else if (bolinhaVencedor)
            {
                resultadoFinal = "Jogador O venceu!";
            }
            else
            {
                resultadoFinal = "Empate!";
            }

            Console.WriteLine($"Resultado: {resultadoFinal}");

            break;
        }

        //Garante a troca entre os jogadores
        trocaJogador *= -1;
    }

    Console.Write("\nDeseja recomeçar o jogo? (S ou s para recomeçar | Qualquer outra tecla para sair) -> ");
    string? decisaoUsuario = Console.ReadLine();
    if (decisaoUsuario == "S" || decisaoUsuario == "s")
    {
        continue;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Até logo!");
        break;
    }
}