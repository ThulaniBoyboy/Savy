using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using savy.contracts.Factories;
using savy.domain.Entities.Catalog;

namespace savy.logics.Factories
{
   public class ProductFactory : IEntityFactory<Product>
   {
       private savyDbContext _db;

       public ProductFactory(savyDbContext db)
       {
           _db = db;
       }

       public Task<bool> CreateAsync(Product entity)
       {
           if(entity == null)
                throw new ArgumentNullException(nameof(entity));
            return await Task<bool>.Factory.StartNew(() =>
            {
                _db.Products.AddAsync(entity);
                _db.SaveChangesAsync();
                return true;
            }
            );
       }
        public Task<Product> GetAsync(int id)
       {
            Throw new NotImplementedException();
       }
        
        public Task<bool> RemoveAsync(int id)
       {
            Throw new NotImplementedException();
       }
        
        public async Task<ICollection<Product>> GetAsync()
       {
           if(! await _db.Products.AnyAsync()) 
                return null;
            return await _db.Products.ToListAsync();
       }
   }
}