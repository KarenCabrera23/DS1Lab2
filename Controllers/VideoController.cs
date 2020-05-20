using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    [HttpPost]
        public ActionResult Create(int IdVideo,string Titulo, int Repro, string Url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@Titulo", Titulo));
            parametros.Add(new SqlParameter("@Repro", Repro));
            parametros.Add(new SqlParameter("@Url", Url));
            BaseHelper.ejecutarSentencia("sp_Video_Insertar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int IdVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int IdVideo, string Titulo, int Repro, string Url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@Titulo", Titulo));
            parametros.Add(new SqlParameter("@Repro", Repro));
            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.ejecutarSentencia("sp_Video_Modificar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Home");
        }

    }
}


