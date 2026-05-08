using System.ComponentModel.DataAnnotations;

namespace ProjetoJogos.Models
{
    // Classe que representa um jogo no sistema
    public class Jogo
    {
        // Chave primária da tabela
        public int Id { get; set; }

        // Campo obrigatório
        [Required]

        // Nome amigável exibido nas Views
        [Display(Name = "Nome do Jogo")]
        public string Nome { get; set; }

        [Display(Name = "Ano de Lançamento")]
        public int AnoLancamento { get; set; }

        public List<JogoPlataforma> JogosPlataformas { get; set; }
    }
}