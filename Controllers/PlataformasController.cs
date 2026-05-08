using Microsoft.AspNetCore.Mvc;
using ProjetoJogos.Dados;
using ProjetoJogos.Models;

namespace ProjetoJogos.Controllers
{
    public class PlataformasController : Controller
    {
        // Variável do banco
        private readonly AppDbContext _context;

        // Construtor
        public PlataformasController(AppDbContext context)
        {
            _context = context;
        }

        /*
            LISTA TODAS AS PLATAFORMAS
        */
        public IActionResult Index()
        {
            return View(_context.Plataformas.ToList());
        }

        /*
            EXIBE O FORMULÁRIO
        */
        public IActionResult Create()
        {
            return View();
        }

        /*
            RECEBE OS DADOS DO FORMULÁRIO
        */
        [HttpPost]
        public IActionResult Create(Plataforma plataforma)
        {
            // Adiciona plataforma
            _context.Plataformas.Add(plataforma);

            // Salva no banco
            _context.SaveChanges();

            // Retorna para Index
            return RedirectToAction("Index");
        }
    }
}