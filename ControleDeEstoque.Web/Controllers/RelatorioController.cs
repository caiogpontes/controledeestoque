﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Web.Controllers
{
    public class RelatorioController : Controller
    {
        public ActionResult PosicaoEstoque()
        {
            return View();
        }

        public ActionResult Ressuprimento()
        {
            return View();
        }
    }
}