using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroCliente2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CadastroCliente2.Controllers
{
    public class SituacoesController : Controller
    {
        private CrudDbContext _crudContext;

        public SituacoesController(CrudDbContext crudContext)
        {
            _crudContext = crudContext;
        }

        public IActionResult Index()
        {
            var situacoes = _crudContext.Situacoes.AsNoTracking().ToList();
            return View(situacoes);
        }

        public IActionResult Excluir(int id)
        {
            var situacao = _crudContext.Situacoes.Single(p => p.Id == id);
            _crudContext.Remove(situacao);
            _crudContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var situacao = _crudContext.Situacoes.FirstOrDefault(p => p.Id == id) ?? new Situacoes();

            return View(situacao);
        }

        public IActionResult Gravar(Situacoes situacao)
        {

            if (situacao.Id > 0)
            {
                _crudContext.Update(situacao);
            }
            else
            {
                _crudContext.Add(situacao);
            }

            _crudContext.SaveChanges();

            return RedirectToAction("Editar", new { id = situacao.Id });
        }
    }
}
