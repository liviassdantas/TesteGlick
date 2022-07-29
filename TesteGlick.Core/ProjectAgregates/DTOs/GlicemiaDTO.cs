using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGlick.Core.ProjectAgregates.DTOs
{
    public class GlicemiaDTO
    {
        public Int32 Id { get; set; }
        public Int32 IdPaciente { get; set; }
        public Int16 Valor { get; set; }
        public DateTime DataHora { get; set; }

    }
}
