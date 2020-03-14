
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using WebApiEmptransporte.Models;  
using Microsoft.EntityFrameworkCore;

namespace WebApiEmptransporte.Controllers
 {     
[Route("api/[controller]")]     
[ApiController]     
  public class PropietariosController : ControllerBase     
        {        
        private readonly CrudTransporteContext _context;

        // Constructor
        public PropietariosController(CrudTransporteContext contexts)
        { _context = contexts;
       /*     if (_context.Propietario.Count() == 0)             
                        {                 
                        _context.Propietario.Add(new Propietarios { PropietarioId = 122343434 });                 _context.SaveChanges();             
                        }    */     
        }      


        // GET: api/Propietario

        [HttpGet] 
        public async Task<ActionResult<IEnumerable<Propietarios>>> GetPropietarioItems() 
        {
            return await _context.Propietario.ToListAsync();
        }


        // GET: registro  api/Propietario/id

        [HttpGet("{id}", Name = "GetPropietario")] 
        public async Task<ActionResult<Propietarios>> GetPropietarioItem(int id) 
        {    

            var propietarioItem = await _context.Propietario.FindAsync(id);     
            if (propietarioItem == null)    
                {         
                return NotFound();     
                }     
            return propietarioItem; 
        }

        // POST: api/Propietarios
        [HttpPost]
        public async Task<ActionResult<Propietarios>> PostPropietarioItem(Propietarios item)
        {

            _context.Propietario.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPropietarioItem), new { id = item.PropietarioId}, item);

            
        }




        // PUT: api/Propietario/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropietarioItem(int id, Propietarios item)
        {
            if (id != item.PropietarioId)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();

        }



        // DELETE: api/Propietario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropietarioItem(int id)
        {
            var propietarioItem = await _context.Propietario.FindAsync(id);
            if (propietarioItem == null)
            {
                return NotFound();
            }
            _context.Propietario.Remove(propietarioItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }      
        

}