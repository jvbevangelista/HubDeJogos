using HubDeJogos.Models;
using HubDeJogos.Controler;

namespace HubDeJogos.Service
{
    public static class ExecutarJogoDaVelha
    {
        public static void IniciarJogo()
        {
            int vitoriaJ1 = 0, vitoriaJ2 = 0, empate = 0;

            TabuleiroJogoDaVelha.InicializarTabuleiro();
            TabuleiroJogoDaVelha.ExibirTabuleiro();

            do
            {
                JogoDaVelhaControler.movimentosJogador1();
                JogoDaVelhaControler.checarVencedor();
                if (JogoDaVelhaControler.venceu == true)
                {
                    vitoriaJ1++;
                    break;
                }

                if (JogoDaVelhaControler.empatou == true)
                {
                    empate++;
                    break;
                }
                JogoDaVelhaControler.movimentosJogador2();
                JogoDaVelhaControler.checarVencedor();
                if (JogoDaVelhaControler.venceu == true)
                {
                    vitoriaJ2++;
                    break;
                }

                if (JogoDaVelhaControler.empatou == true)
                {
                    empate++;
                    break;
                }
            } while (JogoDaVelhaControler.venceu == false);

            Thread.Sleep(3000);
            Console.Clear();
            Menu.ApresentarMenuDeJogos();

        }
        

    }
}
