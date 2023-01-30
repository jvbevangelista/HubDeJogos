namespace HubDeJogos.Models
{
    public class Usuario
    {
        //atributos
        public string NomeDeUsuario { get; set; } = null!;
        public string Senha { get; set; } = null!;

        public int Pontuacao { get; private set; }

        public int ColocacaoRanking { get; private set; }
       

        




    }

}
