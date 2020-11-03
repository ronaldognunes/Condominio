using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Domain.objetosDeValor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Condominio.Domain.Commands.OrdemServico
{
    public class OrdemServicoCommandHandler:
        IRequestHandler<AlterarOrdemServicoCommand,RetornoCommands>,
        IRequestHandler<IncluirOrdemServicoCommand, RetornoCommands>,
        IRequestHandler<ExcluirOrdemServicoCommand, RetornoCommands>,
    {
        private readonly IOrdemDeServicoRepository _ordemDeServicoRepository;
        public OrdemServicoCommandHandler(IOrdemDeServicoRepository repository)
        {
            _ordemDeServicoRepository = repository;
        }

        public async Task<RetornoCommands> Handle(AlterarOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var ordemServico = new OrdemDeServico(request.nomeServico,request.descricao,request.tipoGarantia,request.periodo,request.valorServico,new PrestadorServico(request.nomePrestador,request.telefonePrestador,request.cpfPrestador));
                await _ordemDeServicoRepository.update(request.id, ordemServico);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString()};
            }
        }

        public async Task<RetornoCommands> Handle(IncluirOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var ordemServico = new OrdemDeServico(request.nomeServico, request.descricao, request.tipoGarantia, request.periodo, request.valorServico, new PrestadorServico(request.nomePrestador, request.telefonePrestador, request.cpfPrestador));
                await _ordemDeServicoRepository.insert( ordemServico);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(ExcluirOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _ordemDeServicoRepository.delete(request.id);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!"};
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }
    }
}
