using System;
using System.Collections.Generic;

#nullable disable

namespace Aprobos.mvc.Models
{
    public partial class Raza
    {
        public Raza()
        {
            Tipo = new HashSet<Tipo>();
        }

        public int IdRaza { get; set; }
        public string NombreRaza { get; set; }
        public int EstadoRaza { get; set; }

        public virtual ICollection<Tipo> Tipo { get; set; }
    }
}
