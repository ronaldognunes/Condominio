using System.Collections.Generic;
using System.Threading.Tasks;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.Interfaces;

namespace Condominio.Infra.data
{
    public abstract class Repository<T> :IRepository<T> where T : Entidade
    {
        public void delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<T>> findAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> findById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void insert(T objeto)
        {
            throw new System.NotImplementedException();
        }

        public void update(int id, T objeto)
        {
            throw new System.NotImplementedException();
        }
    }
}