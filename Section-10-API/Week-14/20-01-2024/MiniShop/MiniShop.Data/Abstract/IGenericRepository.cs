using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsyncNew(Expression<Func<TEntity, bool>> options=null); //içine bir fonksiyon gelecek ama çalıştır demiyoruz. bu şekilde kullanılacak GetAllAsync(c=>!c.IsDeleted && c.IsActive ) options değişken adı.optionsta filtre seçeneklerini yazacağız. yani her koşul için farklı metot yazmıycaz.
        Task<TEntity> CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task HardDeleteAsync(TEntity entity);
  


    }
}
