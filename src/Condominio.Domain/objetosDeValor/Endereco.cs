using Condominio.Domain.Core.ObjetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.objetosDeValor
{
    public class Endereco : ObjetoDeValor
    {
        public Endereco(string rua, string bairro, string cidade, string estado, string cep, string referencia)
        {
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.referencia = referencia;
            AddNotifications(new Contract().Requires()
                .IsNotNullOrEmpty(rua,"rua","Rua não informada.")
                .IsNotNullOrEmpty(bairro,"bairro","Bairro não informado.")
                .IsNotNullOrEmpty(cidade,"cidade","Cidade não informada.")
                .IsNotNullOrEmpty(estado,"estado","Estado não informado.")
                .IsNotNullOrEmpty(cep,"cep","Cep não informado.")
            );
        }

        public string rua { get; private set; }
        public string bairro { get; private set; }
        public string cidade { get; private set; }
        public string estado { get; private set; }
        public string cep { get; private set; }
        public string referencia { get; private set; }
    }
}