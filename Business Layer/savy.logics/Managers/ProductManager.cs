using System;
using System.Collections.Generic;
using System.Text;
using savy.contracts.Repository;

namespace savy.logics.Managers
{
        public class ProductManager : IProductRepository 
    {
        private IEntitiyFactory<Product> _factory;
        private IValidator<Product> _validator;
        private IExceptionHandler _handler;

        public ProductManager(IEntityFactory<Product> factory, IValidator<Product> validator, IExceptionHandler handler)
        {
            _factory = factory;
            _handler = handler;
            _validator = validator;
        }




        public bool AddProduct(Product product)
        {
            if(_validator.IsValid(product))
            return _handler.Run(() => _factory.CreateAsync(product).Result);
            return false;

        }
            
        public Product GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }     
        
        public bool RemoveProduct(int id)
        {
            throw new System.NotImplementedException();
        }     
        public ICollection<Product> GetProduct()
        
        {
            return _handler.Run(() => _factory.GetAllAsync().Result);
        }
                    
    }
}