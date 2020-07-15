using System.Collections.Generic;
using System.Threading.Tasks;
using Condominio.Domain.Core.Entidades;

namespace Condominio.Domain.Interfaces
{
    public interface IRepository<T> where T : Entidade 
    {
         Task<T> findById(string id);
         Task<List<T>> findAll();
         Task update(string id, T objeto);
         Task insert(T objeto);
         Task delete(string id);
    }
}