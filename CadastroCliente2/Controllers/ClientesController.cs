using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroCliente2.Models;

namespace CadastroCliente2.Controllers
{
    public class ClientesController : Controller

    {
        private CrudDbContext _crudContext;
        public ClientesController(CrudDbContext crudContext)
        {
            _crudContext = crudContext;
        }

        public IActionResult Index()
        {
            var clientes = _crudContext
            .Clientes
            .Include(i => i.Situacao)
            .AsNoTracking()
            .ToList();

            return View(clientes);
        }

        public IActionResult Excluir(int id)
        {
            var cliente = _crudContext.Clientes.Single(p => p.Id == id);
            _crudContext.Remove(cliente);
            _crudContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            ViewBag.Situacoes = _crudContext
            .Situacoes
            .Select(c => new SelectListItem() { Text = c.Descricao, Value = c.Id.ToString() })
            .ToList();

            var cliente = _crudContext.Clientes.FirstOrDefault(p => p.Id == id) ?? new Clientes();

            return View(cliente);
        }

        public IActionResult Gravar(Clientes cliente)
        {

            if (cliente.Id > 0)
            {
                _crudContext.Update(cliente);
            }
            else
            {
                _crudContext.Add(cliente);
            }

            _crudContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
