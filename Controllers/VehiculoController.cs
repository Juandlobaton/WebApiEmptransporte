
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using WebApiEmptransporte.Models;  
using Microsoft.EntityFrameworkCore;

namespace WebApiEmptransporte.Controllers
 {     
[Route("api/[controller]")]     
[ApiController]     
  public class VehiculoController : ControllerBase     
        {        
        private readonly CrudTransporteContext _context;          
            public VehiculoController(CrudTransporteContext context)         
            {             _context = context;              
             /*   if (_context.vehiculos.Count() == 0)             
                {                 
                _context.vehiculos.Add(new Vehiculo { Id_vehiculo = 122343434 });                 _context.SaveChanges();             
                }         */
            }      

        
        // GET: api/vehiculo

        [HttpGet] 
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetvehiculoItems() 
        {
            return await _context.vehiculos.ToListAsync();
        }


        // GET: registro  api/vehiculo/id

        [HttpGet("{id}", Name = "Getvehiculo")] 
        public async Task<ActionResult<Vehiculo>> GetvehiculoItem(int id) 
        {    

            var vehiculoItem = await _context.vehiculos.FindAsync(id);     
            if (vehiculoItem == null)    
                {         
                return NotFound();     
                }     
            return vehiculoItem; 
        }

        // POST: api/vehiculos
        [HttpPost]
        public async Task<ActionResult<Vehiculo>> PostvehiculoItem(Vehiculo item)
        {

            _context.vehiculos.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetvehiculoItem), new { id = item.Id_vehiculo}, item);

            
        }




        // PUT: api/vehiculo/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutvehiculoItem(int id, Vehiculo item)
        {
            if (id != item.Id_vehiculo)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();

        }



        // DELETE: api/vehiculo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletevehiculoItem(int id)
        {
            var vehiculoItem = await _context.vehiculos.FindAsync(id);
            if (vehiculoItem == null)
            {
                return NotFound();
            }
            _context.vehiculos.Remove(vehiculoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }      
        

}