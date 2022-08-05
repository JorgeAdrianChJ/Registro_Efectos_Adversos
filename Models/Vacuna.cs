using System;
using System.Collections.Generic;

namespace Registro_Efectos_Adversos.Models
{
    public partial class Vacuna
    {
        public Vacuna()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Marca { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public int? Lote { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? LugarAplicacion { get; set; }
        public string? Observaciones { get; set; }
        public string? Respuesta1 { get; set; }
        public string? Respuesta2 { get; set; }
        public string? Respuesta3 { get; set; }
        public string? Respuesta4 { get; set; }
        public string? Respuesta5 { get; set; }
        public string? Respuesta6 { get; set; }
        public string? Respuesta7 { get; set; }
        public string? Respuesta8 { get; set; }
        public string? Respuesta9 { get; set; }

        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
