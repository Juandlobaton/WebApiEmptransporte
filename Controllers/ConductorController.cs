

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using WebApiEmptransporte.Models;  
using Microsoft.EntityFrameworkCore;



namespace WebApiEmptransporte.Controllers
 {     
[Route("api/[controller]")]     
[ApiController]     
  public class ConductorController : ControllerBase     
        {        
        private readonly CrudTransporteContext _context;          
            public ConductorController(CrudTransporteContext context)         
            {             _context = context;              
               /* if (_context.conductors.Count() == 0)             
                {                 
                _context.conductors.Add(new Conductor { Id_Conductor = 122343434 });                 _context.SaveChanges();             
                }         */
            }      

             // GET: api/Conductor

        [HttpGet] 
        public async Task<ActionResult<IEnumerable<Conductor>>> GetConductorItems() 
        {
            return await _context.conductors.ToListAsync();
        }


        // GET: registro  api/Conductor/id

        [HttpGet("{id}", Name = "GetConductor")] 
        public async Task<ActionResult<Conductor>> GetConductorItem(int id) 
        {    

            var ConductorItem = await _context.conductors.FindAsync(id);     
            if (ConductorItem == null)    
                {         
                return NotFound();     
                }     
            return ConductorItem; 
        }

        // POST: api/Conductors
        [HttpPost]
        public async Task<ActionResult<Conductor>> PostConductorItem(Conductor item)
        {

            _context.conductors.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetConductorItem), new { id = item.Id_Conductor}, item);

            
        }




        // PUT: api/Conductor/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConductorItem(int id, Conductor item)
        {
            if (id != item.Id_Conductor)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();

        }



        // DELETE: api/Conductor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConductorItem(int id)
        {
            var ConductorItem = await _context.conductors.FindAsync(id);
            if (ConductorItem == null)
            {
                return NotFound();
            }
            _context.conductors.Remove(ConductorItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }      
        

}