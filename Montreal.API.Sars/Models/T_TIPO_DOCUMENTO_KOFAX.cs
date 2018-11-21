using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montreal.API.Sars.Models
{
    public class TipoDocumentoKofax
    {

        public int Id { get; set; }
        public int IdTipoDocumento { get; set; }
        public string ClasseKTM { get; set; }
        public string ClasseKofax { get; set; }

    }
}
