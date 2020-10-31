﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prodam.Data;

namespace Prodam.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly DALContext dalContext;

        public EmpresasController(DALContext dalContext)
        {
            this.dalContext = dalContext;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}