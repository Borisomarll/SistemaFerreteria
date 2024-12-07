using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class entUsuario
    {
        public int idUsuario { get; set; }
        public required string nombres { get; set; }
        public required string contraseña { get; set; }
        public required string nombrecompleto { get; set; }
        public required string correoelectronico { get; set; }
        public bool estado { get; set; }

    }
}