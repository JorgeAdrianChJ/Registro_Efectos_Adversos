using System;
using System.Collections.Generic;

namespace Registro_Efectos_Adversos.Models
{
    public partial class Medico
    {
        public Medico()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public string? Identificacion { get; set; }
        public string? CodigoProfesional { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public string? Pais { get; set; }
        public string? Estado { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
