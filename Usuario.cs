using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio
{
    public class Usuario
    {
        public int usuarioId { get; set; }
        public string nomeUsuario { get; set; }
        public string senha { get; set; }
        public string perfil { get; set; }
    }
}
