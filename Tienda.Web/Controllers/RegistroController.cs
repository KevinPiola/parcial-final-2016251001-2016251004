using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.DataAccess;
using Tienda.Models;

namespace Tienda.Web.Controllers
{
    public class RegistroController : Controller
    {
        private RegistroRepository RegistroRepository;

        public RegistroController()
        {
            this.RegistroRepository = new RegistroRepository();
        }

        public IActionResult Index()
        {
            var list = this.RegistroRepository.Registros.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Agregar ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Registro registro)
        {
            if (ModelState.IsValid)
            {
                if (this.RegistroRepository.Existe(registro) == false)
                {
                    this.RegistroRepository.Guardar(registro);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remover(int id)
        {
            //Consultamos el Objeto
            var registro = this.RegistroRepository.Registros.FirstOrDefault(x => x.RegistroId == id);
            //Retornamos la Vista
            return View(registro);
        }

        [HttpPost]
        public IActionResult Remover(Registro registro)
        {
            bool guardado = this.RegistroRepository.Delete(registro.RegistroId);
            if (guardado)
            {
                return RedirectToAction("Index");
            }
            return View(registro);
        }
    }
}