using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tl2_tp8_2025_BenjaminVilloldo.Models;

namespace tl2_tp8_2025_BenjaminVilloldo.Controllers;

public class PresupuestoController : Controller
{
    private readonly ILogger<PresupuestoController> _logger;

    public PresupuestoController(ILogger<PresupuestoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() 
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

 
}
