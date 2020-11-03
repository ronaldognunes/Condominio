using Condominio.Domain.objetosDeValor.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.OrdemServico
{
    public class OrdemServicoCommand
    {
        public OrdemServicoCommand(string id,string nomeServico, string descricao, RTipoGarantia tipoGarantia, int periodo, decimal valorServico, string nome, int telefone, string cpf)
        {
            this.id = id;
            this.nomeServico = nomeServico;
            this.descricao = descricao;
            this.tipoGarantia = tipoGarantia;
            this.periodo = periodo;
            this.valorServico = valorServico;
            this.nomePrestador = nome;
            this.telefonePrestador = telefone;
            this.cpfPrestador = cpf;
        }
        public string id { get; set; }
        public string nomeServico { get;  set; }
        public string descricao { get;  set; }
        public RTipoGarantia tipoGarantia { get;  set; }
        public int periodo { get;  set; }
        public decimal valorServico { get;  set; }
        public string nomePrestador { get;  set; }
        public int telefonePrestador { get;  set; }
        public string cpfPrestador { get;  set; }

    }
}
