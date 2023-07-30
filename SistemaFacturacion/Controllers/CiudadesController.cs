using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace SistemaFacturacionWebApiREST.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CiudadesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CiudadesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<List<Ciudad>> Get()
        {
            var ciudades = await context.Ciudades.ToListAsync();
            return ciudades;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Ciudad ciudad)
        {
            var existeCiudadConElMismoNombre = await context.Ciudades.AnyAsync(ciudadDB => ciudadDB.Nombre == ciudad.Nombre);
            if (existeCiudadConElMismoNombre)
            {
                return BadRequest($"Ya existe una ciudad con el nombre {ciudad.Nombre}");
            }
            context.Add(ciudad);
            return await context.SaveChangesAsync() == 1;
        }
    }
}
