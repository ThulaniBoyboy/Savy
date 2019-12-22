using System;
using savy.domain.Entities.BaseModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace savy.contracts.Factories
{
    public interface IEntityFactory<T> where T: BaseEntity
    {
        Task<bool> CreateAsync(T entity);
        Task<T> GetAsync(int id);
        Task<bool> RemoveAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}