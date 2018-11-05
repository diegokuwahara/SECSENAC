using SECSENAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SECSENAC.Controllers.API
{
    public class OcorrenciasController : ApiController
    {
        private ApplicationDbContext _context;

        public OcorrenciasController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<Ocorrencia> GetOcorrencias()
        {
            var ocorrencias = _context.Ocorrencias.ToList();
            return ocorrencias;
        }
    }
}
