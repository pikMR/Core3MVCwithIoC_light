using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderReceiverSystem.Interfaces;
using OrderReceiverSystem.Modelos.ViewModel;

namespace OrderReceiverSystem.Controladores
{
    public class OrderListDataController : Controller
    {
        private readonly ILocation _location;

        public OrderListDataController(IServiceProvider serviceProvider,ILocation location)
        {
            var myService = new MyService(serviceProvider);
            System.Threading.Thread.Sleep(2500);
            _location = location;
            _location.Append($"{nameof(OrderListDataController)} " + DateTime.Now + " | ");
        }
        public IActionResult Index()
        {
            var viewModel = new OrderViewModel(_location.Get());
            return View(viewModel);
        }

        public IActionResult Call()
        {
            _location.Append("_CALL");
            return View(new OrderViewModel(_location.Get() + " _ "+DateTime.Now));
        }
    }
    public class MyService
    {
        public MyService(IServiceProvider serviceProvider)
        {
            var data = (ILocation)serviceProvider.GetService(typeof(ILocation));
            data.Append($"{nameof(MyService)} " + DateTime.Now + " | ");
        }
    }
}