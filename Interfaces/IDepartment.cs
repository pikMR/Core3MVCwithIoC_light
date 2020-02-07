using System;

namespace OrderReceiverSystem.Interfaces
{
    public interface IDepartment : IDisposable
    {
        public void GetStockAvailability();
    }
}
