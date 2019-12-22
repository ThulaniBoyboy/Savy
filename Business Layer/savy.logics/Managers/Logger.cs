using System;
using System.Collections.Generic;
using System.Text;
using savy.contracts.Repository;

namespace savy.logics.Managers
{
    public class Logger : ILogger
    {
        public void Log(Exception ex)
        {
            throw new Exception(ex.Message, ex.InnerException);
        }
    }


   
}