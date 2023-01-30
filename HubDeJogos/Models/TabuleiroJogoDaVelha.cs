



namespace HubDeJogos.Models
{
    public static class TabuleiroJogoDaVelha
    {
        public static string[,] tabuleiro = new string[3, 3];

        public static void InicializarTabuleiro()
        {
            TabuleiroJogoDaVelha.tabuleiro[0, 0] = "1";
            TabuleiroJogoDaVelha.tabuleiro[0, 1] = "2";
            TabuleiroJogoDaVelha.tabuleiro[0, 2] = "3";
            TabuleiroJogoDaVelha.tabuleiro[1, 0] = "4";
            TabuleiroJogoDaVelha.tabuleiro[1, 1] = "5";
            TabuleiroJogoDaVelha.tabuleiro[1, 2] = "6";
            TabuleiroJogoDaVelha.tabuleiro[2, 0] = "7";
            TabuleiroJogoDaVelha.tabuleiro[2, 1] = "8";
            TabuleiroJogoDaVelha.tabuleiro[2, 2] = "9";
        }

        public static void ExibirTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(TabuleiroJogoDaVelha.tabuleiro[i, j]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
                Console.WriteLine("---------");
            }
        }
    }
}

    