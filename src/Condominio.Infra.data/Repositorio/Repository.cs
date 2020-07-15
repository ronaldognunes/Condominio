using System.Collections.Generic;
using System.Threading.Tasks;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;
using MongoDB.Driver;

namespace Condominio.Infra.data.Repositorio
{
    public abstract class Repository<T> : IRepository<T> where T : Entidade
    {
        private IMongoCollection<T> _db;
        private readonly DbContext _context;

        protected Repository(DbContext context)
        {
            _context = context;
            _db = _context.database.GetCollection<T>(typeof(T).Name);
        }

        public async Task<T> findById(string id)
        {
            return await _db.FindAsync<T>(o => o.id == id ).Result.FirstOrDefaultAsync();
        }

        public async Task<List<T>> findAll()
        {
            return await _db.FindAsync<T>(o => true).Result.ToListAsync();
        }

        public async Task update(string id, T objeto)
        {
             await _db.ReplaceOneAsync<T>(o => o.id == id , objeto);
        }

        public async Task insert(T objeto)
        {
            await _db.InsertOneAsync(objeto);
        }

        public async Task delete(string id)
        {
            await _db.DeleteOneAsync<T>(o => o.id == id);
        }
    }
}