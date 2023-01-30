using HubDeJogos.Models;
using System.Collections.Generic;

namespace HubDeJogos.Controler
{

    public class JogadorControler
    {
        public static bool loginBemSucedido = false;
        public static bool usuarioAdicionado = false;
        public static Usuario AdicionarUsuario()
        {

            Console.Clear();
            Console.WriteLine("Escoha o nome do seu jogador: ");
            string? nomeDeUsuario = Console.ReadLine();
            Console.WriteLine("Digite a senha do seu jogador: ");
            string? senha = Console.ReadLine();
            Usuario usuario = new Usuario { NomeDeUsuario = nomeDeUsuario, Senha = senha };
            Program.usuarios.Add(usuario);
            Console.WriteLine("Usuário adicionado com sucesso!");
            Menu.MenuInicial();
            return usuario;

        }

        public static void FazerLogin()
        {
            Console.Clear();
            Console.WriteLine("Digite nome do usuário: ");
            string nomeDeUsuario = Console.ReadLine();
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            //lógica de checagem de usuário e senha

            foreach (var usuario in Program.usuarios)
            {
                if (usuario.NomeDeUsuario == nomeDeUsuario && usuario.Senha == senha)
                {
                    loginBemSucedido = true;
                    Menu.ApresentarMenuDeJogos();
                    break;
                }
            }

            if (!loginBemSucedido)
            {
                Console.WriteLine("Erro ao logar.");
                Console.WriteLine("Conta não encontrada ou dados de login inválidos!");
                Thread.Sleep(1000);
                Console.WriteLine("Voltando ao menu inicial.");
                Thread.Sleep(1000);
                Menu.MenuInicial();
            }
        }
    }
}