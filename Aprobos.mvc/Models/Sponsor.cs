using System;
using System.Collections.Generic;

#nullable disable

namespace Aprobos.mvc.Models
{
    public partial class Sponsor
    {
        public Sponsor()
        {
            Codigo = new HashSet<Codigo>();
        }

        public int IdSponsor { get; set; }
        public string NombreSponsor { get; set; }
        public string UrlSponsor { get; set; }
        public byte[] LogoSponsor { get; set; }
        public bool EstadoSponsor { get; set; }

        public virtual ICollection<Codigo> Codigo { get; set; }
    }
}
