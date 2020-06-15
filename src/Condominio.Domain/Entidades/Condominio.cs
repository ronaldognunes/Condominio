using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Condominio:Base
    {
        public string nome { get; set; }
        
        public Endereco endereco { get; set; }
    }
}