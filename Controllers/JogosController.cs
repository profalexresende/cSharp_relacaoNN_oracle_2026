using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoJogos.Dados;
using ProjetoJogos.Models;

namespace ProjetoJogos.Controllers
{
    public class JogosController : Controller
    {
        // Variável que representa o banco
        private readonly AppDbContext _context;

        // Construtor
        public JogosController(AppDbContext context)
        {
            _context = context;
        }

        /*
            LISTAGEM DE JOGOS
        */
        public IActionResult Index()
        {
            /*
                Include -> carrega os relacionamentos

                ThenInclude -> carrega os dados da plataforma
            */
            var jogos = _context.Jogos
                .Include(j => j.JogosPlataformas)
                .ThenInclude(jp => jp.Plataforma)
                .ToList();

            return View(jogos);
        }

        /*
            EXIBE O FORMULÁRIO
        */
        public IActionResult Create()
        {
            /*
                MultiSelectList cria uma lista
                de múltipla seleção.

                O usuário poderá escolher
                várias plataformas.
            */
            ViewBag.Plataformas = new MultiSelectList(
                _context.Plataformas.ToList(),
                "Id",
                "Nome"
            );

            return View();
        }

        /*
            RECEBE OS DADOS DO FORMULÁRIO
        */
        [HttpPost]
        public IActionResult Create(Jogo jogo, int[] plataformasSelecionadas)
        {
            // Salva o jogo no banco
            _context.Jogos.Add(jogo);

            _context.SaveChanges();

            /*
                Percorre todas as plataformas
                escolhidas pelo usuário.
            */
            foreach (var plataformaId in plataformasSelecionadas)
            {
                // Cria a ligação entre jogo e plataforma
                JogoPlataforma jp = new JogoPlataforma
                {
                    JogoId = jogo.Id,
                    PlataformaId = plataformaId
                };

                // Adiciona no banco
                _context.JogosPlataformas.Add(jp);
            }

            // Salva tudo
            _context.SaveChanges();

            // Redireciona para Index
            return RedirectToAction("Index");
        }
    }
}