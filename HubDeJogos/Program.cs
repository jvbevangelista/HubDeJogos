using HubDeJogos.Controler;
using HubDeJogos.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HubDeJogos;

public class Program
{
    public static List<Usuario> usuarios = new List<Usuario>();
    
    static void Main(string[] args)
    {
        Menu.MenuInicial();

    }

}
