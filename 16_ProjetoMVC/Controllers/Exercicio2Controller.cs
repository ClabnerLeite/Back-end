using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _16_ProjetoMVC.Controllers
{
    public class Exercicio2Controller : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

        
    }
}