
using APIHormigon.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

namespace APIHormigon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalcularResultado([FromBody] Datos datos)
        {
            double resultado =
                (0.11980433 * datos.Cement) +
                (0.10386581 * datos.BlastFurnaceSlag) +
                (0.08793432 * datos.FlyAsh) -
                (0.14991842 * datos.Water) +
                (0.2922246 * datos.SuperPlasticizer) +
                (0.01808621 * datos.CoarseAggregate) +
                (0.02019035 * datos.FineAggregate) +
                (0.11422207 * datos.Age);

            return Ok(resultado);
        }
    }
}
