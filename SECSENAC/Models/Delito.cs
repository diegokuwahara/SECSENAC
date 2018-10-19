using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SECSENAC.Models
{
    public class Delito
    {
        public Delito()
        {
            Ocorrencias = new HashSet<Ocorrencia>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Artigo { get; set; }
        public int NumVitimas { get; set; }
        public bool houveMorte { get; set; }
        public bool houveRoubo { get; set; }
        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}