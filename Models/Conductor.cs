
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApiEmptransporte.Models
{
    public class Conductor
    {
        
        [Key]
        public int Id_Conductor { get; set; }
        public string Nombre { get; set; }         
        public string Apellido { get; set; }     
        public string  Date  { get; set; } 
        public string CC { get; set; }
        public string Id_vehiculo { get; set; }

        
    }
}