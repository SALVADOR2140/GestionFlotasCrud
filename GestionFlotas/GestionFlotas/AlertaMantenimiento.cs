using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFlotas
{
    public class AlertaMantenimiento
    {
        [Key]public int AlertaMantenimientoId { get; set; }
        public DateTime FechaAlerta { get; set; } // Fecha y hora de la alerta de mantenimiento
        public string Descripcion { get; set; } // Descripción de la alerta de mantenimiento

        //RELACIONES
        //relacion de muchos a uno con Camion
        [ForeignKey("CamionId")]
        public int CamionId { get; set; }
        public Camion? Camion { get; set; } 
    }
}
