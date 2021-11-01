using System;
using System.Collections.Generic;

#nullable disable

namespace Aprobos.mvc.Models
{
    public partial class Adoptar
    {
        public int IdAdoptar { get; set; }
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public byte[] DocumentoAdoptar { get; set; }
        public byte EstadoAdoptar { get; set; }

        public virtual Administrador IdAdministradorNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
