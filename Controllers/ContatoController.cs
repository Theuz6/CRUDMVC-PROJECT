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
    public IActionResult Editar(int id)
    {
        ContatoModel contato = _contatoRepositorio.buscarId(id);
        return View(contato);
    }

    public IActionResult Deletar(int id)
    {
        _contatoRepositorio.deletar(id);
        return RedirectToAction("Index");
    }
    
    public IActionResult VerificarDeletar(int id)
    {
        ContatoModel contato = _contatoRepositorio.buscarId(id);
        return View(contato);
    }
    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepositorio.adicionar(contato);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Atualizar(ContatoModel contato)
    {
        _contatoRepositorio.atualizar(contato);
        return RedirectToAction("Index");
    }
}
