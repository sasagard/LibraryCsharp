using Microsoft.AspNetCore.Mvc;

namespace LibraryCsharp.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SaludosController : ControllerBase
	{
		/// <summary>
		/// Obtiene un saludo personalizado.
		/// </summary>
		/// <param name="nombre">El nombre de la persona a saludar. Si no se proporciona, se usa "Mundo" como valor predeterminado.</param>
		/// <returns>Un saludo que dice "Hola {nombre}".</returns>
		[HttpGet("hola")]
		public IActionResult ObtenerSaludo(string? nombre)
		{
			nombre = nombre ?? "Mundo";
			return Ok($"Hola {nombre}");
		}
	}
}
