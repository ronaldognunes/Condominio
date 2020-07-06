using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;
using Condominio.Domain.objetosDeValor.Enums;

namespace Condominio.Domain.Entidades
{
    public class OrdemDeServico:Entidade
    {
        public OrdemDeServico(string nomeServico, string descricao, RTipoGarantia tipoGarantia, int periodo, decimal valorServico, PrestadorServico prestador)
        {
            this.nomeServico = nomeServico;
            this.descricao = descricao;
            this.tipoGarantia = tipoGarantia;
            this.periodo = periodo;
            this.valorServico = valorServico;
            this.prestador = prestador;       
            AddNotifications(prestador);     
        }

        public string nomeServico { get; private set; }
        public string descricao { get; private set; }
        public RTipoGarantia tipoGarantia { get; private set; }
        public int periodo { get; private set; }
        public decimal valorServico { get; private set; }
        public PrestadorServico prestador { get; private set; }
    }
}