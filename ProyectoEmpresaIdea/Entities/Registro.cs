using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime fechayhora { get; set; }
        public Boolean Entrada { get; set; }
        public int IdUsuario { get; set; }

    }
}
