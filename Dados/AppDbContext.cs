using Microsoft.EntityFrameworkCore;
using ProjetoJogos.Models;

namespace ProjetoJogos.Dados
{
    /*
        Classe responsável pela comunicação
        entre o sistema e o banco de dados.

        O DbContext funciona como uma ponte
        entre o C# e o Oracle.
    */
    public class AppDbContext : DbContext
    {
        // Construtor do contexto
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        /*
            Cada DbSet representa uma tabela
            no banco de dados.
        */

        public DbSet<Jogo> Jogos { get; set; }

        public DbSet<Plataforma> Plataformas { get; set; }

        public DbSet<JogoPlataforma> JogosPlataformas { get; set; }

        /*
            Método responsável pelas configurações
            avançadas das tabelas e relacionamentos.
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
                Define chave primária composta.

                A tabela JogoPlataforma será identificada por:
                - JogoId
                - PlataformaId
            */
            modelBuilder.Entity<JogoPlataforma>()
                .HasKey(jp => new { jp.JogoId, jp.PlataformaId });

            /*
                Configura relação:

                Um Jogo possui muitos registros
                em JogosPlataformas
            */
            modelBuilder.Entity<JogoPlataforma>()
                .HasOne(jp => jp.Jogo)
                .WithMany(j => j.JogosPlataformas)
                .HasForeignKey(jp => jp.JogoId);

            /*
                Configura relação:

                Uma Plataforma possui muitos registros
                em JogosPlataformas
            */
            modelBuilder.Entity<JogoPlataforma>()
                .HasOne(jp => jp.Plataforma)
                .WithMany(p => p.JogosPlataformas)
                .HasForeignKey(jp => jp.PlataformaId);
        }
    }
}