using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEmptransporte.Models
{
    public class Propietarios
    {
        [Key]
        public int PropietarioId { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }         
        public string Apellido { get; set; }     
        public string Telefono { get; set; } 
        public string Ciudad { get; set; }

        
    }
}