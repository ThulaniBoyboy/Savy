using System;
using System.Collections.Generic;
using System.Text;

namespace savy.contracts.Handlers
{
    public interface IExceptionHandler
    {
        T Run<T>(Func<T> func);
    }
}