using SECSENAC.Models;
using System;
using System.Collections.Generic;
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
        // GET: Ocorrencias
        public ActionResult Index()
        {
            var viewModel = _context.Ocorrencias.ToList();

            return View(viewModel);
        }

        public ActionResult New()
        {
            return View("Form");
        }
    }
}