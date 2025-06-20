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

        public int CamionId { get; set; }  // Solo se guarda como dato, no como FK, Se queda como dato aislado


        /* Se elimina la navegación, no se realiza la navegacion por que ahi si tendria una relacion con la tabla de SQLSERVER 
        public Camion? Camion { get; set; }
        no debemos agregar propiedades de navegacion aqui para que no se relacionen las tablas 
         * Solo se esta  guardando el ID del camión como dato numérico, 
         * sin relación ni integridad referencial con la tabla Camiones de la otra base SQL Server.*/
    }
}
