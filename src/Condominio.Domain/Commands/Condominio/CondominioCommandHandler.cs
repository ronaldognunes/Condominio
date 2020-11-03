using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Domain.objetosDeValor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Condominio.Domain.Commands.Condominio
{
    public class CondominioCommandHandler :
        IRequestHandler<AlterarCondominioCommand, RetornoCommands>,
        IRequestHandler<InserirCondominioCommand, RetornoCommands>,
        IRequestHandler<ExcluirCondominioCommand, RetornoCommands>
    {
        private readonly ICondominioRepository _condominioRepository;
        public CondominioCommandHandler(ICondominioRepository repository)
        {
            _condominioRepository = repository;
        }
        public async Task<RetornoCommands> Handle(AlterarCondominioCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var condominio = new CondominioEnd(request.nome, new Endereco(request.rua,request.bairro,request.cidade,request.estado,request.cep,request.referencia));
                await _condominioRepository.update(request.id, condominio);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso." };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(InserirCondominioCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var condominio = new CondominioEnd(request.nome, new Endereco(request.rua, request.bairro, request.cidade, request.estado, request.cep, request.referencia));
                await _condominioRepository.insert( condominio);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso." };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(ExcluirCondominioCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _condominioRepository.delete(request.id);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso." };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }
    }
}
