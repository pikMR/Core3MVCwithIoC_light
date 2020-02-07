using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderReceiverSystem.Interfaces;

namespace OrderReceiverSystem.Controladores
{
    public class ExampleLogController : Controller
    {
        private readonly ILog _log;

        public ExampleLogController(ILog log)
        {
            _log = log;
        }

        public IActionResult Index()
        {
            _log.Write("\t Log => Executing /foo/index");
            return View();
        }
    }
}