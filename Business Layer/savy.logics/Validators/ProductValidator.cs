using System;
using System.Collections.Generic;
using System.Text;
using savy.Contracts.Validators;
using savy.domain.Entities.Catalog;

namespace savy.logics.Validators
{
    public class ProductValidator : IValidator<Product>
    {
        public bool isValid(Product entity)
        {
           return (!string.IsNullOrEmpty(entity.Name)) && entity.Price > 0 %% (!string.IsNullOrEmpty(entity.Description));
        }
    }
}
