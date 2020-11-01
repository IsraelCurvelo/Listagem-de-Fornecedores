using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Prodam.Data;
using Prodam.Facade;
using Prodam.Models.Dominio;

namespace Prodam.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly DALContext dalContext;

        public EmpresasController(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empresa empresa)
        {

            EmpresaFacade cf = new EmpresaFacade(dalContext);
             cf.Cadastrar(empresa);

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Voltar()
        {
            return RedirectToAction("Filtro", "Fornecedores");
        }
    }
}
