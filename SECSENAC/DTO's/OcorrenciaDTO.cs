using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SECSENAC.DTO_s
{
    public class OcorrenciaDto
    {
        public int Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data da ocorrência")]
        public DateTime DataOcorrencia { get; set; }

        public string Local { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public string Titulo
        {
            get
            {
                return Id != 0 ? "Alteração de Ocorrência" : "Nova Ocorrência";
            }
        }

        [Display(Name = "Qtd de criminosos")]
        public int QtdAutores { get; set; }

        [Display(Name = "Qtd de veículos roubados")]
        public int QtdVeiculos { get; set; }

        [Display(Name = "Número de Vítimas")]
        public int NumVitimas { get; set; }

        [Display(Name = "Houve agressão?")]
        public bool houveAgressao { get; set; }

        [Display(Name = "Houve mortes?")]
        public bool houveMorte { get; set; }

        [Display(Name = "Houve roubo?")]
        public bool houveRoubo { get; set; }

        public OcorrenciaDto()
        {
            Id = 0;
        }
    }
}