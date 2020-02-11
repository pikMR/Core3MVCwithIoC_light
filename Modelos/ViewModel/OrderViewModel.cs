using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderReceiverSystem.Modelos.ViewModel
{
    public class OrderViewModel
    {
        public OrderViewModel(string id)
        {
            Id = id;
        }
        public string Id { get; }
    }
}
