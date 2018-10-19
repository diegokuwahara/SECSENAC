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
        public ICollection<Delito> Delitos { get; set; }
    }
}