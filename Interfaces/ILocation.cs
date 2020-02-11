using System;

namespace OrderReceiverSystem.Interfaces
{
    public interface ILocation : IDisposable
    {
        string Get();
        void Append(string data);
        void Clear();
    }
}
