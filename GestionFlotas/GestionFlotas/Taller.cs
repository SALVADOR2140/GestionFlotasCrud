using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFlotas
{
    public class Taller
    {
        [Key] public int TallerId { get; set; }
        public string Nombre { get; set; }
        public string Cuidad { get; set; }
        public int CapacidadMaxima { get; set; }

        //RELACIONES

        // Relación 1:N → Un taller puede tener muchos mantenimientos
        public List<Mantenimiento>? Mantenimientos { get; set; }

    }
}
