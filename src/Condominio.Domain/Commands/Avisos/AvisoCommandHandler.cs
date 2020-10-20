using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Condominio.Domain.Commands.Avisos
{
    public class AvisoCommandHandler :
        IRequestHandler<AlterarAvisoCommand, RetornoCommands>,
        IRequestHandler<ExcluirAvisoCommand,RetornoCommands>,
        IRequestHandler<IncluirAvisoCommand,RetornoCommands>,
        IRequestHandler<EnviarAvisoCommand,RetornoCommands>
    {
        private readonly IAvisosRepository _avisoRepository;
        public AvisoCommandHandler(IAvisosRepository repositorio)
        {
            _avisoRepository = repositorio;
        }
        public async Task<RetornoCommands> Handle(AlterarAvisoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var aviso = new Aviso(request.id, request.descricao, request.situacao, request.dataGeracao, request.dataEnvio);
                await _avisoRepository.update(request.id,aviso);                    
                return new RetornoCommands { mensagens = "Operação realizada com sucesso." };
            }
            catch (Exception e)
            {
                return new RetornoCommands { mensagens = e.Message.ToString() };
            }
                     
        }

        public async Task<RetornoCommands> Handle(ExcluirAvisoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _avisoRepository.delete(request.id);
                return new RetornoCommands { mensagens = "Opereçaõ realizada com sucesso." };
            }
            catch (Exception e)
            {
                return new RetornoCommands { mensagens = e.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(IncluirAvisoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var aviso = new Aviso(request.id, request.descricao, request.situacao, request.dataGeracao, request.dataEnvio);
                await _avisoRepository.insert(aviso);

                return new RetornoCommands { mensagens = "Operação realizada com sucesso." };
            }
            catch (Exception e )
            {
                return new RetornoCommands { mensagens = e.Message.ToString() };
            }
        }

        public Task<RetornoCommands> Handle(EnviarAvisoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
