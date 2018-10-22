using SECSENAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SECSENAC.ViewModels
{
    public class OcorrenciaFormViewModel
    {
        public int Id { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }

        public string Titulo
        {
            get
            {
                return Id != 0 ? "Alteração de Ocorrência" : "Nova Ocorrência";
            }
        }

        public int QtdAutores { get; set; }
        public int QtdVeiculos { get; set; }
        public int NumVitimas { get; set; }
        public bool houveAgressao { get; set; }
        public bool houveMorte { get; set; }
        public bool houveRoubo { get; set; }
        public IEnumerable<Delito> Delitos { get; set; }

        public OcorrenciaFormViewModel()
        {
            Id = 0;
        }


    }
}