using AutoMapper;
using SECSENAC.DTO_s;
using SECSENAC.Models;
using SECSENAC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SECSENAC.Controllers
{
    public class OcorrenciasController : Controller
    {
        private ApplicationDbContext _context;

        public OcorrenciasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Ocorrencias
        public ActionResult Index()
        {
            var viewModel = _context.Ocorrencias.ToList().Select(Mapper.Map<Ocorrencia, OcorrenciaDto>);

            return View(viewModel);
        }

        public ActionResult New()
        {
            var delitos = _context.Delitos.ToList();
            var viewModel = new OcorrenciaFormViewModel()
            {
                Delitos = delitos
            };

            return View("Form", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var ocorrencia = _context.Ocorrencias.Include(o => o.Delitos).Single(o => o.Id == id);

            return View("Form");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Save(Ocorrencia ocorrencia)
        {
            if (!ModelState.IsValid)
            {
                var delitos = _context.Delitos.ToList();
                var viewModel = new OcorrenciaFormViewModel()
                {
                    Delitos = delitos,

                };
                return View("Form", viewModel);
            }

            if (ocorrencia.Id == 0)
            {
                _context.Ocorrencias.Add(ocorrencia);
            }
            else
            {
                var OcorrenciaInDb = _context.Ocorrencias.Single(o => o.Id == ocorrencia.Id);
                OcorrenciaInDb.DataOcorrencia = ocorrencia.DataOcorrencia;
                OcorrenciaInDb.Descricao = ocorrencia.Descricao;
                OcorrenciaInDb.houveAgressao = ocorrencia.houveAgressao;
                OcorrenciaInDb.houveMorte = ocorrencia.houveMorte;
                OcorrenciaInDb.houveRoubo = ocorrencia.houveRoubo;
                OcorrenciaInDb.Local = ocorrencia.Local;
                OcorrenciaInDb.NumVitimas = ocorrencia.NumVitimas;
                OcorrenciaInDb.QtdAutores = ocorrencia.QtdAutores;
                OcorrenciaInDb.QtdVeiculos = ocorrencia.QtdVeiculos;
            }

            _context.SaveChanges();
            
            return RedirectToAction("Index", "Ocorrencias");
        }
    }
}