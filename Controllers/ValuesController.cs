using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEmptransporte.Models;  
using Microsoft.EntityFrameworkCore;

namespace WebApiEmptransporte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly CrudTransporteContext _context;

        public ValuesController(CrudTransporteContext context)
        {
            _context = context;
        }

        // GET: api/Values
        [HttpGet]
        public List<object> Get()
        /*{

           // using (Models.CrudTransporteContext db = new Models.CrudTransporteContext())
           

              return new string[] { "value1", "value2" };
        } */
         {
            var result = from pm in _context.Propietario join veh in _context.vehiculos on pm.PropietarioId.ToString() equals veh.Id_propietario
                         join con in _context.conductors on veh.Id_vehiculo.ToString() equals con.Id_vehiculo
                         select new
                         {
                             Vehiculo_propietario = veh.Marca,
                             Placa_vehiculo = veh.Placa,
                             Nombre_Propietario = pm.Nombre,
                             Conductor_asignado = con.Nombre,
                             Modelo_Vehiculo = veh.Modelo,
                             Fecha_modelo = veh.Fecha
                                 
                         }; 
                            

                List<object> query = new List<object>(result);


                return query;
        }


    // GET: api/Values/5
    [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public List<object> GetIn(Guid id)
        {
            {
                var result = from pm in _context.vehiculos select pm;

                List<object> query = new List<object>(result);


                return query;
            }
        } 
    }
}
