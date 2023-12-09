using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PruebaMVC.Models;

namespace PruebaMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Contact(){
        return View();
    }

    // [HttpPost]
    // [ValidateAntiForgeryToken]
    public IActionResult EnviarCorreo(ContactoViewModel modelo)
    {
        if (ModelState.IsValid)
        {
            // Aquí puedes agregar la lógica para enviar el correo o realizar alguna acción
            // utilizando la información proporcionada en el modelo.

            // Por ejemplo, puedes enviar un correo electrónico utilizando un servicio de correo.
            // Aquí es solo un ejemplo básico:
            EnviarCorreo(modelo.Correo, "Asunto del Correo", modelo.Mensaje);

            ViewBag.MensajeExito = "Mensaje enviado con éxito. ¡Gracias por ponerte en contacto!";
        }

        return View(); // Puedes redirigir a una vista de agradecimiento o a la misma vista.
    }

    private void EnviarCorreo(string correo, string asunto, string mensaje)
    {
        // Aquí puedes implementar la lógica para enviar el correo.
        // Puedes utilizar bibliotecas como SendGrid, SmtpClient, etc.
        // Por ejemplo:
        // servicioCorreo.Enviar(correo, asunto, mensaje);
    }

}

