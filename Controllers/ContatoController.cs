using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDMVC_PROJECT.Models;
using CRUDMVC_PROJECT.Repository;

namespace CRUDMVC_PROJECT.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepository _contatoRepositorio;
    public ContatoController(IContatoRepository contatoRepositorio)
    {
        _contatoRepositorio = contatoRepositorio;
    }
    public IActionResult Index()
    {
        List<ContatoModel> contato = _contatoRepositorio.listarContatos();
        return View(contato);
    }
    public IActionResult Criar()
    {
        return View();
    }
    public IActionResult Editar()
    {
        return View();
    }
    public IActionResult VerificarDeletar()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepositorio.adicionar(contato);
        return RedirectToAction("Index");
    }
}
