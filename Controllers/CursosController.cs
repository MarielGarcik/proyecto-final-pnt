using Microsoft.AspNetCore.Mvc;
using Contarla_Para_Vivir_PNT.Models;

namespace Contarla_Para_Vivir_PNT.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            // Datos temporales simulados (hasta tener SQL)
            var cursos = new List<Curso>
            {
                new Curso { Id = 1, Titulo = "Oratoria inicial", Descripcion = "Perder el miedo a hablar", Nivel = "Principiante", Modalidad = "Zoom" },
                new Curso { Id = 2, Titulo = "Storytelling emocional", Descripcion = "Conectá con tu audiencia", Nivel = "Intermedio", Modalidad = "Grabado" },
                new Curso { Id = 3, Titulo = "Mentoría intensiva", Descripcion = "Trabajo uno a uno", Nivel = "Avanzado", Modalidad = "Asesoría" }
            };

            return View(cursos);
        }
        public IActionResult Mentorias()
        {
            return View();
        }

        public IActionResult Oratoria()
        {
            return View();
        }

        public IActionResult TalleresLiterarios()
        {
            return View();
        }

        public IActionResult Empresarte()
        {
            return View();
        }

        public IActionResult DosisLiterarias()
        {
            return View();
        }


    }
}
