using Condominio.Domain.Core.ObjetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.objetosDeValor
{
    public class PrestadorServico: ObjetoDeValor
    {
        public PrestadorServico(string nome, int telefone, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(nome,"nome","Nome do prestador não informado.")
                .IsNotNull(telefone,"telefone","Telefone não informado")
                .IsNotNullOrEmpty(cpf,"cpf","cpf não informado")
            );
            
        }

        public string nome { get; private set; }
        public int telefone { get; private set; }
        public string cpf { get; private set; }
    }
}