using System;
using System.Collections.Generics;
using System.Text;
using savy.contracts.Handlers;

namespace savy.logics.Handlers
{
    public class Exceptionandler :IExceptionHandler
    {
        private ILogger _logger;

        public Exceptionandler(ILogger logger)
        {
            _logger = logger;
        }

        public T Run<T>(Func<T> func)
        {
            try
            {
               return func.Invoke(); 
            }
            catch (System.Exception e)
            {
                
               _logger.Log(e);
            }    

            return default(T);
        }
    }
}