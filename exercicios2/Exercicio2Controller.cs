using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace exercicios2
{
    public class Exercicio2Controller : Controller
    {
        private readonly ILogger<Exercicio2Controller> _logger;



        public IActionResult Index()
        {
            return View();
        }
    }
}