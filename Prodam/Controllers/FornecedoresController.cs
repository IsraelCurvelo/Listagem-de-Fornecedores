using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Prodam.Data;
using Prodam.Facade;
using Prodam.Models;
using Prodam.Models.Dominio;
using Prodam.Models.ViewModels;

namespace Prodam.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly DALContext dalContext;

        public FornecedoresController(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }
        
        public IActionResult Index()
        {
            return View();        
        }

        public IActionResult Cadastrar(Empresa empresa)
        {
            EmpresaFacade empresaF = new EmpresaFacade(dalContext);
            List<Empresa> resultado = new List<Empresa>();
            foreach (EntidadeDominio x in empresaF.Consultar(empresa))
            {
                resultado.Add((Empresa)x);
            }


            var viewModel = new FornecedorViewModel { Empresas = resultado };


            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(Fornecedor fornecedor)
        {
            FornecedorFacade fc = new FornecedorFacade(dalContext);
            fornecedor.MomentoCadastro = DateTime.Today;           
           

            if (fornecedor.TipoPessoa)
            {
                return RedirectToAction("CadastrarFisica", "Fornecedores", fornecedor);
            }
            else
            {
                FornecedorFacade facade = new FornecedorFacade(dalContext);
                facade.Cadastrar(fornecedor);


                Telefone tvm = new Telefone { FornecedorId = fornecedor.Id };

                return RedirectToAction("CadastrarTelefone", "Fornecedores", tvm);
               
            }            

        }

        public IActionResult CadastrarFisica (Fornecedor fornecedor)
        {

            
            
            return View(fornecedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarFisica(Fornecedor fornecedor, PessoaFisica pessoaFisica)
        {
            FornecedorFacade facade = new FornecedorFacade(dalContext);            
             var con = facade.CadastrarFornecedor(fornecedor);
            if (con != null)
            {
                return RedirectToAction(nameof(Error));
            }
            else
            {

                Telefone tvm = new Telefone { FornecedorId = fornecedor.Id };

                return RedirectToAction("CadastrarTelefone", "Fornecedores", tvm);
            }
        }

      


        public IActionResult CadastrarTelefone(Telefone tvm)
        {
                       

            return View(tvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarTelefonee(Telefone telefone)
        {
            TelefoneFacade facade = new TelefoneFacade(dalContext);
            facade.Cadastrar(telefone);

            telefone.Numero = null;

            return RedirectToAction("CadastrarTelefone", "Fornecedores", telefone);
        }


        public IActionResult Filtro()
        {


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Filtro(Fornecedor fornecedor)
        {
            FornecedorFacade facade = new FornecedorFacade(dalContext);
            var forn = facade.ConsultarFiltro(fornecedor);

            return View("ResultadoFiltro", forn);
        }

        public IActionResult ResultadoFiltro(ICollection<Fornecedor> fornecedores)
        {
            return View(fornecedores);
        }

        
        public IActionResult Sair()
        {

            return RedirectToAction(nameof(Index));
        }

        public IActionResult VoltarInicio()
        {

            return RedirectToAction("Filtro", "Fornecedores");
        }

        public IActionResult Error()
        {
            var viewModel = new ErrorViewModel
            {
                Message = "Fornecedor menor de idade",
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
