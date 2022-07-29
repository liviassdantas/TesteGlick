using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGlick.Core.ProjectAgregates.DTOs
{
    public class PacienteDTO
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public Int32 Idade { get; set; }
        public Boolean Diabetico { get; set; }
    }
}
