using System.Collections.Generic;
using System.Threading.Tasks;

namespace Condominio.Domain.Interfaces
{
    public interface IService<T> where T : class
    {
         Task<List<T>> getAll();         
         Task<T> getId(T obj );
         Task add(T obj);
         Task update(T obj);
         Task delete(T obj)
         
    }
}