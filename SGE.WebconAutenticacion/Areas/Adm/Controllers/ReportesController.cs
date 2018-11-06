﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SGE.Entidades.Contexto;
using SGE.Entidades.Reportes;
using SGE.Entidades.Repositorio;
using SGE.Entidades.Sesion;
using SGE.Entidades.Transformadores;
using SGE.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGE.WebconAutenticacion.Areas.Adm.Controllers
{
    public class ReportesController : Controller
    {
        // GET: Admin/Reportes
        public ActionResult Index()
        {
            BaseRepositorio<Cliente> repoCliente = new BaseRepositorio<Cliente>();
            ICollection<Cliente> clientes = repoCliente.GetAll();
            ViewBag.clientes = clientes.Select(c => new SelectListItem() {
                Text = c.NombreUsuario,
                Value = c.Id.ToString(),
            });

            BaseRepositorio<Transformador> repoTransformador = new BaseRepositorio<Transformador>();
            ICollection<Transformador> transformadores = repoTransformador.GetAll();
            ViewBag.transformadores = transformadores.Select(t => new SelectListItem() {
                Text = t.codigo.ToString(),
                Value = t.Id.ToString(),
            });

            ViewBag.tiposDispositivos = new SelectList(new[]
                {
                    new { Value="inteligente", Text="Inteligente" },
                    new { Value="estandar", Text="Estandar" },
                }, "Value", "Text");

            return View();
        }

        [HttpPost]
        public JsonResult Consultar(string fechaDesde, string fechaHasta, string tipoReporte, string idObjeto) {
            DateTime fDesde = Convert.ToDateTime(fechaDesde);
            DateTime fHasta = DateTime.Now;

            if (!String.IsNullOrEmpty(fechaHasta)) {
                fHasta = Convert.ToDateTime(fechaHasta);
            }
            decimal consumo = 0;
            switch (tipoReporte.ToLower()) {
                case "hogar":
                    consumo = Reporte.consumoPorHogarYPeriodo(Convert.ToInt32(idObjeto), fDesde, fHasta);
                    break;
                case "tiposdisp":
                    consumo = Reporte.consumoPorTipoDeDispositivoPorPeriodo(idObjeto, fDesde, fHasta);
                    break;
                case "transformador":
                    consumo = Reporte.consumoTransformadorPorPeriodo(Convert.ToInt32(idObjeto), fDesde, fHasta);
                    break;
                default:
                    return Json(new { success = false, error = "No se reconoce el tipo de reporte" });
            }

            
            return Json(new { success = true, resultado = consumo, tipoReporte = tipoReporte });
        }
    }
}