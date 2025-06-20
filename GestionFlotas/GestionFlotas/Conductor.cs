using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFlotas
{
    public class Conductor
    {
        [Key]public int ConductorId { get; set; }
        public string Nombre { get; set; }
        public string Licencia { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //RELACIONES
        //relacion de muchos a uno con Camion
        [ForeignKey("CamionId")]
        public int CamionId { get; set; } // Relación con Camion
        public Camion? Camion { get; set; } // Navegación a la entidad Camion
    }
}
