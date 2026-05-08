namespace ProjetoJogos.Models
{
    /*
        Classe intermediária da relação N:N

        Esta tabela serve para conectar:
        - Jogos
        - Plataformas

        Ela guarda:
        qual jogo pertence a qual plataforma
    */
    public class JogoPlataforma
    {
        // Chave estrangeira para Jogo
        public int JogoId { get; set; }

        // Objeto Jogo relacionado
        public Jogo Jogo { get; set; }

        // Chave estrangeira para Plataforma
        public int PlataformaId { get; set; }

        // Objeto Plataforma relacionado
        public Plataforma Plataforma { get; set; }
    }
}