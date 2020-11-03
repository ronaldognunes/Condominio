using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Condominio.Domain.Commands.Ocorrencia
{
    public class OcorrenciaCommandHandler :
        IRequestHandler<AlterarOcorrenciaCommand, RetornoCommands>,
        IRequestHandler<IncluirOcorrenciaCommand, RetornoCommands>,
        IRequestHandler<ExcluirOcorrenciaCommand, RetornoCommands>


    {
        private readonly IOcorrenciaRepository _ocorrenciaRepository;
        public OcorrenciaCommandHandler(IOcorrenciaRepository repository)
        {
            _ocorrenciaRepository = repository;
        }

        public async Task<RetornoCommands> Handle(AlterarOcorrenciaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var ocorrencia = new Ocorrencias(request.descricao,request.titulo,request.DataOcorrencia,request.idUsuario,request.nome);
                await _ocorrenciaRepository.update(request.id, ocorrencia);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso !" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(IncluirOcorrenciaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var ocorrencia = new Ocorrencias(request.descricao, request.titulo, request.DataOcorrencia, request.idUsuario, request.nome);
                await _ocorrenciaRepository.insert( ocorrencia);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso !" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(ExcluirOcorrenciaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _ocorrenciaRepository.delete(request.id);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso !" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }
    }
}
