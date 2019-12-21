using System;

namespace savy.contracts.Repository
{
    public interface ILogger
    {
        void Log(Exception ex);
    }
}