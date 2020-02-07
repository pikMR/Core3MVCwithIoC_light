using System;

namespace OrderReceiverSystem.Interfaces
{
    public interface ILocation : IDisposable
    {
        public void GetLocation(string coordenadas);
    }
}
