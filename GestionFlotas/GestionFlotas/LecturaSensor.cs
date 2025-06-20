using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFlotas
{
    public class LecturaSensor
    {
        [Key]
        public int LecturaSensorId { get; set; }

        public DateTime FechaHora { get; set; }

        public double Kilometraje { get; set; }

        public string EstadoCamion { get; set; } = string.Empty;

        public int CamionId { get; set; }  // Solo se guarda como dato, no como FK

        // ❌ Se elimina la navegación
        // public Camion? Camion { get; set; }
    }
}
