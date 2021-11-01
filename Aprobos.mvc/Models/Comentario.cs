using System;
using System.Collections.Generic;

#nullable disable

namespace Aprobos.mvc.Models
{
    public partial class Comentario
    {
        public int IdComentario { get; set; }
        public int IdUsuario { get; set; }
        public string DetalleComentario { get; set; }
        public string EstadoComentario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
