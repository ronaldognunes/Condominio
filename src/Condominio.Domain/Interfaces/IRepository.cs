using System.Collections.Generic;
using System.Threading.Tasks;
using Condominio.Domain.Core.Entidades;

namespace Condominio.Domain.Interfaces
{
    public interface IRepository<T> where T : Entidade 
    {
         Task<T> findById(int id);
         Task<List<T>> findAll();
         void update(int id, T objeto);
         void insert(T objeto);
         void delete(int id);
    }
}