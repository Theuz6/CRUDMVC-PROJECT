using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDMVC.Models;

namespace CRUDMVC.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepository _contatoRepositorio;
    public ContatoController(IContatoRepository contatoRepositorio)
    {
        _contatoRepositorio = contatoRepositorio;
    }
    public IActionResult Index()
    {
        return View();
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
    [httpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepositorio.adicionar(contato);
        return RedirectToAction("Index");
    }
}
