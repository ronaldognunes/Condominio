using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Condominio:Entidade
    {
        public string nome { get; private set; }
        
        public Endereco endereco { get; private set; }
    }
}