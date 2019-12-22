using System;
using System.Collections.Generic;
using System.Text;

namespace savy.contracts.Validators
{
    public interface IValidator<T>
    {   
        bool isValid(T entity);
    }
}