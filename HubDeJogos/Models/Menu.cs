using HubDeJogos.Controler;
using HubDeJogos.Service;

namespace HubDeJogos.Models
{
    public class Menu
    {

        public static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO HUB DE JOGOS");
            Console.WriteLine("ESTA APLICAÇÃO DE CONSOLE FOI CRIADA POR JOÃO VICTOR BARBOSA EVANGELISTA");
            Console.WriteLine("DURANTE O PROGRAMA SHARP CODERS DA IMÃ LEARNING PLACE");
            Thread.Sleep(1000);
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma Opção");
            Console.WriteLine("1 - Fazer login");
            Console.WriteLine("2 - Cadastrar novo Usuário");
            Console.WriteLine("0 - Encerrar o Programa");
            Console.WriteLine("---------------");
            int option = int.Parse(Console.ReadLine());

            do
            {
                switch (option)
                {
                    case 1:
                        JogadorControler.FazerLogin();
                        break;
                    case 2:
                        var usuario = JogadorControler.AdicionarUsuario();
                        Program.usuarios.Add(usuario);
                        break;
                    case 0:
                        Console.WriteLine("Aperte qualquer tecla para encerrar o programa.");
                        break;
                }
            } while (JogadorControler.loginBemSucedido == false);
        }

        public static void ApresentarMenuDeJogos()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Jogo da Velha");
            Console.WriteLine("2 - Batalha  Naval");
            Console.WriteLine("3 - Ranking de Jogadores");
            Console.WriteLine("0 - Sair do Hub de Jogos");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("COMO JOGAR: ESCOLHA UMA DAS CASAS NUMERADAS E APERTE O NÚMERO CORRESPONDENTE PARA MARCÁ-LA.");
                    Console.WriteLine("VENCE QUEM FECHAR UMA LINHA COMPLETA PRIMEIRO");
                    Console.WriteLine("JOGADOR 1 JOGA COM X");
                    Console.WriteLine("JOGADOR 2 JOGA COM O");
                    ExecutarJogoDaVelha.IniciarJogo();
                    break;
                case 2:
                    //TODO iniciar Batalha Naval
                    Console.WriteLine("Jogo disponível na próxima atualização do projeto!");
                    Thread.Sleep(3000);
                    MenuInicial();
                    break;
                case 3:
                    //TODO apresentar ranking
                    Console.WriteLine("Funcionalidade disponível na proxíma atualização do projeto!");
                    Thread.Sleep(3000);
                    MenuInicial();
                    break;
                case 0:
                    Console.WriteLine("Muito obrigado por utilizar o Hub de Jogos :)");
                    Console.WriteLine("Aperte qualquer tecla para sair");
                    break;
            }
        }
    }
}

