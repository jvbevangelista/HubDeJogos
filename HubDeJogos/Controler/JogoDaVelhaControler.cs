using HubDeJogos.Models;

namespace HubDeJogos.Controler
{
    public static class JogoDaVelhaControler
    {
        public static bool venceu = false, empatou = false;

        public static void movimentosJogador1()
        {
            Console.Write("Jogador 1, digite o número da casa do tabuleiro que você quer marcar: ");
            int movimentoJogador1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você marcou {movimentoJogador1}");

            try
            {
                if (movimentoJogador1 == 1)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[0, 0] == "X" || TabuleiroJogoDaVelha.tabuleiro[0, 0] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[0, 0] = "X";
                    }
                }
                else if (movimentoJogador1 == 2)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[0, 1] == "X" || TabuleiroJogoDaVelha.tabuleiro[0, 1] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[0, 1] = "X";
                    }
                }
                else if (movimentoJogador1 == 3)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[0, 2] == "X" || TabuleiroJogoDaVelha.tabuleiro[0, 2] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[0, 2] = "X";
                    }
                }
                else if (movimentoJogador1 == 4)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[1, 0] == "X" || TabuleiroJogoDaVelha.tabuleiro[1, 0] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[1, 0] = "X";
                    };
                }
                else if (movimentoJogador1 == 5)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "X" || TabuleiroJogoDaVelha.tabuleiro[1, 1] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[1, 1] = "X";
                    }
                }
                else if (movimentoJogador1 == 6)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[1, 2] == "X" || TabuleiroJogoDaVelha.tabuleiro[1, 2] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[1, 2] = "X";
                    }
                }
                else if (movimentoJogador1 == 7)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[2, 0] == "X" || TabuleiroJogoDaVelha.tabuleiro[2, 0] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[2, 0] = "X";
                    }
                }
                else if (movimentoJogador1 == 8)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[2, 1] == "X" || TabuleiroJogoDaVelha.tabuleiro[2, 1] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[2, 1] = "X";
                    }
                }
                else if (movimentoJogador1 == 9)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "X" || TabuleiroJogoDaVelha.tabuleiro[2, 2] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador1();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[2, 2] = "X";
                    }
                }
                else
                {
                    Console.WriteLine("Movimento Inválido!");

                    movimentosJogador1();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Movimento Inválido! Escolha um dos números disponíveis no tabuleiro!");
                movimentosJogador1();
            }


            Console.Clear();
        }

        public static void movimentosJogador2()
        {
            Console.Write("Jogador 2, digite o número da casa do tabuleiro que você quer marcar: ");
            int movimentoJogador2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você marcou {movimentoJogador2}");

            try
            {
                if (movimentoJogador2 == 1)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[0, 0] == "X" || TabuleiroJogoDaVelha.tabuleiro[0, 0] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[0, 0] = "O";
                    }
                }
                else if (movimentoJogador2 == 2)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[0, 1] == "X" || TabuleiroJogoDaVelha.tabuleiro[0, 1] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[0, 1] = "O";
                    }
                }
                else if (movimentoJogador2 == 3)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[0, 2] == "X" || TabuleiroJogoDaVelha.tabuleiro[0, 2] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[0, 2] = "O";
                    }
                }
                else if (movimentoJogador2 == 4)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[1, 0] == "X" || TabuleiroJogoDaVelha.tabuleiro[1, 0] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[1, 0] = "O";
                    }
                }
                else if (movimentoJogador2 == 5)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "X" || TabuleiroJogoDaVelha.tabuleiro[1, 1] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[1, 1] = "O";
                    }
                }
                else if (movimentoJogador2 == 6)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[1, 2] == "X" || TabuleiroJogoDaVelha.tabuleiro[1, 2] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[1, 2] = "O";
                    }
                }
                else if (movimentoJogador2 == 7)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[2, 0] == "X" || TabuleiroJogoDaVelha.tabuleiro[2, 0] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[2, 0] = "O";
                    }
                }
                else if (movimentoJogador2 == 8)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[2, 1] == "X" || TabuleiroJogoDaVelha.tabuleiro[2, 1] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[2, 1] = "O";
                    }
                }
                else if (movimentoJogador2 == 9)
                {
                    if (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "X" || TabuleiroJogoDaVelha.tabuleiro[2, 2] == "O")
                    {
                        Console.WriteLine("Casa já escolhida! Escolha outra casa.");
                        movimentosJogador2();
                    }
                    else
                    {
                        TabuleiroJogoDaVelha.tabuleiro[2, 2] = "O";
                    }
                }
                else
                {
                    Console.WriteLine("Movimento Inválido!");
                    movimentosJogador2();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Movimento Inválido! Escolha um dos números disponíveis no tabuleiro!");
                movimentosJogador2();
            }
            Console.Clear();
        }

        public static void checarVencedor()
        {
            while (venceu == false)
            {
                // Vitórias do X 
                if ((TabuleiroJogoDaVelha.tabuleiro[0, 0] == "X") && (TabuleiroJogoDaVelha.tabuleiro[0, 1] == "X") && (TabuleiroJogoDaVelha.tabuleiro[0, 2] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[1, 0] == "X") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "X") && (TabuleiroJogoDaVelha.tabuleiro[1, 2] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[2, 0] == "X") && (TabuleiroJogoDaVelha.tabuleiro[2, 1] == "X") && (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 0] == "X") && (TabuleiroJogoDaVelha.tabuleiro[1, 0] == "X") && (TabuleiroJogoDaVelha.tabuleiro[2, 0] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 1] == "X") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "X") && (TabuleiroJogoDaVelha.tabuleiro[2, 1] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 2] == "X") && (TabuleiroJogoDaVelha.tabuleiro[1, 2] == "X") && (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 0] == "X") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "X") && (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 2] == "X") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "X") && (TabuleiroJogoDaVelha.tabuleiro[2, 0] == "X"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 1 ganhou!");
                    break;
                }
                //Vitórias do O
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[0, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[0, 2] == "O"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[1, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 2] == "O"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[2, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "O"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 0] == "O"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 1] == "OX"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 2] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 2] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "O"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "O"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                else if ((TabuleiroJogoDaVelha.tabuleiro[0, 2] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 0] == "O"))
                {
                    venceu = true;
                    Console.WriteLine("Jogador 2 ganhou!");
                    break;
                }
                //Empate
                if ((TabuleiroJogoDaVelha.tabuleiro[0, 0] == "X" | TabuleiroJogoDaVelha.tabuleiro[0, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[0, 1] == "X" | TabuleiroJogoDaVelha.tabuleiro[0, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[0, 2] == "X" | TabuleiroJogoDaVelha.tabuleiro[0, 2] == "O") &&
                    (TabuleiroJogoDaVelha.tabuleiro[1, 0] == "X" | TabuleiroJogoDaVelha.tabuleiro[1, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 1] == "X" | TabuleiroJogoDaVelha.tabuleiro[1, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[1, 2] == "X" | TabuleiroJogoDaVelha.tabuleiro[1, 2] == "O") &&
                    (TabuleiroJogoDaVelha.tabuleiro[2, 0] == "X" | TabuleiroJogoDaVelha.tabuleiro[2, 0] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 1] == "X" | TabuleiroJogoDaVelha.tabuleiro[2, 1] == "O") && (TabuleiroJogoDaVelha.tabuleiro[2, 2] == "X" | TabuleiroJogoDaVelha.tabuleiro[2, 2] == "O"))
                {
                    empatou = true;
                    Console.WriteLine("Vocês empataram!");
                    break;
                }


                if (venceu == false)
                {
                    Console.Clear();
                    TabuleiroJogoDaVelha.ExibirTabuleiro();
                    break;
                }


            }
        }
    }
}
