using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace SistemaFacturacionWebApiREST.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<List<Cliente>> Get()
        {
            var autores = await context.Clientes.ToListAsync();
            return autores;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Cliente cliente)
        {
            try
            {
                if (context.Clientes.Any(clienteDB => clienteDB.Id.Equals(cliente.Id)))
                    context.Update(cliente);
                else
                    context.Add(cliente);
                
                return await context.SaveChangesAsync() == 1;
            }
            catch (Exception)
            {
                throw new Exception("No se pudo actualizar el cliente");
            }
        }
    }
}
