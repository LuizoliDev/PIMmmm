using Microsoft.AspNetCore.Mvc;
using PIM4.Models;
using System.Reflection;

namespace PIM4.Controllers
{
    public class MuseuController : Controller
    {
        public ActionResult Obra(int id)
        {
            var obras = new List<Obra>
            {
                new Obra { Id = 1, Titulo = "MOPA", Descricao = "sdfsdfsdafasfsdafasdfasdfasfasfasfas", Imagem = "https://via.placeholder.com/150" },
                new Obra { Id = 2, Titulo = "Obra 2", Descricao = "Descrição da Obra 2", Imagem = "https://via.placeholder.com/150" },
                new Obra { Id = 3, Titulo = "Obra 3", Descricao = "Descrição da Obra 3", Imagem = "https://via.placeholder.com/150" }
            };

            var obra = obras.FirstOrDefault(o => o.Id == id);

            if (obra == null)
            {
                return NotFound();
            }

            return View(obra);
        }

        public ActionResult Feedback(int id)
        {
            var obras = new List<Obra>
    {
        new Obra { Id = 1, Titulo = "Obra 1", Descricao = "Descrição completa da Obra 1", Imagem = "https://via.placeholder.com/150" },
        new Obra { Id = 2, Titulo = "Obra 2", Descricao = "Descrição completa da Obra 2", Imagem = "https://via.placeholder.com/150" },
        new Obra { Id = 3, Titulo = "Obra 3", Descricao = "Descrição completa da Obra 3", Imagem = "https://via.placeholder.com/150" }
    };

            var obra = obras.FirstOrDefault(o => o.Id == id);

            if (obra == null)
            {
                return NotFound();
            }

            var feedback = new Feedback
            {
                ObraId = obra.Id,
                Titulo = obra.Titulo
            };

            return View(feedback);
        }
        public ActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAdmin(string usuario, string senha)
        {
            if (usuario == "user1" && senha == "1234")
            {
                return RedirectToAction("Admin");
            }
            else
            {
                ViewBag.ErrorMessage = "Usuário ou senha inválidos!";
                return View();
            }
        }
        public ActionResult Admin()
        {   
            return View();
        }
    }
}