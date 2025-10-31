using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tl2_tp8_2025_BenjaminVilloldo.Models;

namespace tl2_tp8_2025_BenjaminVilloldo.Controllers;

public class ProductosController : Controller
{
    private readonly ILogger<ProductosController> _logger;

    public ProductosController(ILogger<ProductosController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() 
    {
        List<Productos> productos = _repo.getAll();
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
