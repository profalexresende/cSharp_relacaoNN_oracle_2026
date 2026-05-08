using System.ComponentModel.DataAnnotations;

namespace ProjetoJogos.Models
{
    // Classe que representa uma plataforma
    public class Plataforma
    {
        // Chave primária
        public int Id { get; set; }

        [Required]

        [Display(Name = "Nome da Plataforma")]
        public string Nome { get; set; }

        /*
            Relação N:N

            Uma plataforma pode possuir vários jogos.

            Exemplo:
            PC -> Minecraft
            PC -> GTA
            PC -> FIFA
        */
        public List<JogoPlataforma> JogosPlataformas { get; set; }
    }
}