using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedPepper.API.Data;
using RedPepper.API.Model;

namespace RedPepper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly DbContextPostgreSql _context;
        public PersonasController(DbContextPostgreSql context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            var personas = await _context.Personas.ToListAsync();
            return Ok(personas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson(int id)
        {
            var persona = await _context.Personas.FirstOrDefaultAsync(p => p.Id == id);
            return Ok(persona);
        }

        // POST: api/TodoItems
        [HttpPost]
        public async Task<IActionResult> PostPerson(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();

            return Ok(CreatedAtAction(nameof(GetPersons), new {id = persona.Id}, persona));
        
        /* The CreatedAtAction method:

            * Returns an HTTP 201 status code if successful. HTTP 201 is the standard response for an HTTP POST method that creates a new resource on the server.
            * Adds a Location header to the response. The Location header specifies the URI of the newly created to-do item.
            * References the GetPersonas action to create the Location header's URI. The C# nameof keyword is used to avoid hard-coding the action name in the CreatedAtAction call.*/           
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(int id, [FromBody] Persona persona) {
            if(id != persona.Id) {
                return BadRequest();
            }

            _context.Entry(persona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id) {
            var person = await _context.Personas.FirstOrDefaultAsync(x => x.Id == id);
            
            if(person == null) {
                return NotFound("Recurso no encontrado");
            }

            _context.Personas.Remove(person);
            await _context.SaveChangesAsync();
            return Ok(person);

        }
    }
}