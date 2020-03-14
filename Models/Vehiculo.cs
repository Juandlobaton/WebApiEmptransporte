
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEmptransporte.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id_vehiculo { get; set; }
        public string Marca { get; set; }         
        public string Modelo { get; set; }     
        public string Fecha  { get; set; } 
        public string Placa { get; set; }
        public string Id_propietario { get; set; }

        
    }
}