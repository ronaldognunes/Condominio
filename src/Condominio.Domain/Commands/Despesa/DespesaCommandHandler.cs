using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Domain.objetosDeValor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Condominio.Domain.Commands.Despesa
{
    public class DespesaCommandHandler :
        IRequestHandler<IncluirDespesaCommand, RetornoCommands>,
        IRequestHandler<AlterarDespesaCommand, RetornoCommands>,
        IRequestHandler<ExcluirDespesaCommand, RetornoCommands>
    {
        private readonly IDespesaRepository _despesaRepository;
        public DespesaCommandHandler(IDespesaRepository repository)
        {
            _despesaRepository = repository;
        }
        public async Task<RetornoCommands> Handle(IncluirDespesaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var despesa = new Despesas(request.nome, request.valTotal,request.descricao, new Fornecedor(request.nomeFornecedor, request.telefoneFornecedor, request.cpfFornecedor, request.cnpjFornecedor));
                await _despesaRepository.insert(despesa);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(AlterarDespesaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var despesa = new Despesas(request.nome, request.valTotal, request.descricao, new Fornecedor(request.nomeFornecedor, request.telefoneFornecedor, request.cpfFornecedor, request.cnpjFornecedor));
                await _despesaRepository.update(request.id,despesa);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(ExcluirDespesaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _despesaRepository.delete(request.id);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }
    }
}
