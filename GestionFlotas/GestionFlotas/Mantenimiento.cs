using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFlotas
{
    public class Mantenimiento
    {
       [Key]public int MantenimientoId { get; set; }

        public DateTime FechaMantenimiento { get; set; }
        public string Tipo { get; set; } 


        //Relaciones 
        //relacion de muchos a uno con Taller
        [ForeignKey("TallerId")]
        public int TallerId { get; set; }

        //relacion de muchos a uno con Camion
        [ForeignKey("CamionId")]
        public int CamionId { get; set; }
        public Taller? Taller { get; set; } 
        public Camion? Camion { get; set; } 

    }
}
