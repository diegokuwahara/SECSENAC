using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SECSENAC.Models
{
    public class Ocorrencia
    {
        public Ocorrencia()
        {
            Delitos = new HashSet<Delito>();
        }
        public int Id { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public int QtdAutores { get; set; }
        public int QtdVeiculos { get; set; }
        public int NumVitimas { get; set; }
        public bool houveAgressao { get; set; }
        public bool houveMorte { get; set; }
        public bool houveRoubo { get; set; }
        public ICollection<Delito> Delitos { get; set; }
    }
}