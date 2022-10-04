using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDMVC.Models;

namespace CRUDMVC.Controllers;

public class ContatoController : Controller
{
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
}
