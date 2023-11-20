using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animes.Models
{

    public class Animes
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string AñoDeEmision {get; set;}
        public string NumeroDeEpisodios { get; set;}
        public string Genero { get; set; }
        public string sinopsis { get; set; }
        public string Fotografia { get; set; }
        public Animes()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            AñoDeEmision = string.Empty;
            NumeroDeEpisodios = string.Empty;
            Genero = string.Empty;
            sinopsis = string.Empty;
            Fotografia = string.Empty;
        }
    }
   
}
