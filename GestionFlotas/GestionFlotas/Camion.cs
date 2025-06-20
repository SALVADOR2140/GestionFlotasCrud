using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFlotas
{
    public class Camion
    {
        [Key]public int CamionId { get; set; } 
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public double KilometrajeActual { get; set; }
        public string Estado { get; set; }

        //RELACIONES
        // Relación 1:N - Un camión puede tener varios conductores
        public List<Conductor>? Conductores { get; set; }

        // Relación 1:N - Un camión puede tener varios mantenimientos programados
        public List<Mantenimiento>? Mantenimientos { get; set; }

        // Relación 1:N - Un camión puede tener muchas lecturas de sensores
        public List<LecturaSensor>? Lecturas { get; set; }

        // Relación 1:N - Un camión puede tener muchas alertas de mantenimiento
        public List<AlertaMantenimiento>? Alertas { get; set; }


    }
}
