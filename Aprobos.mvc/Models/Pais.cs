using System;
using System.Collections.Generic;

#nullable disable

namespace Aprobos.mvc.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdPais { get; set; }
        public string NombrePais { get; set; }
        public string CodigoPais { get; set; }
        public bool EstadoPais { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
