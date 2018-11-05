using AutoMapper;
using SECSENAC.DTO_s;
using SECSENAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SECSENAC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Ocorrencia, OcorrenciaDto>();
            CreateMap<OcorrenciaDto, Ocorrencia>();
        }
    }
}