using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedPepper.API.Data;

namespace RedPepper.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly DbContextPostgreSql _context;
        public ClientesController(DbContextPostgreSql context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> getClientes() {
            var clientes = await _context.Clientes.Include(x => x.Persona).ToListAsync(); 
            return Ok(clientes);
        }


    }
}