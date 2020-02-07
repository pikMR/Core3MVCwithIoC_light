using System;

namespace OrderReceiverSystem.Interfaces
{
    public interface ILog : IDisposable
    {
        public void Write(string message);
    }
}
