using System;
using System.Threading;
using System.Threading.Tasks;
using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Domain.objetosDeValor;
using Condominio.Domain.objetosDeValor.Enums;
using MediatR;

namespace Condominio.Domain.Commands.Usuario
{
    public class UsuarioCommandHandler :
        IRequestHandler<AlterarUsuarioCommand, RetornoCommands>,
        IRequestHandler<AvaliarUsuarioCommad, RetornoCommands>,
        IRequestHandler<CriarUsuarioCommand, RetornoCommands>,
        IRequestHandler<DeletarUsuarioCommand, RetornoCommands>

    {
        private readonly IUsuarioRepository _repository;
        public UsuarioCommandHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        public async Task<RetornoCommands> Handle(AlterarUsuarioCommand request, CancellationToken cancellationToken)
        {
            /*fazer o mapper*/            
            var usuario= new Usuarios(
                request.Id = request.Id,
                request.Nome, 
                request.NumCasa, 
                request.DataNascimento, 
                request.Telefone,  
                new LoginUsuario(request.Perfil, request.Perfil, new Email(request.Email)));
            ;

            if (usuario.Invalid)
                return new RetornoCommands { codRetornos = 01, mensagens = "Dados do Usuário invalido"};

            await _repository.update(request.Id, usuario);
            var retorno = new RetornoCommands();
            retorno.codRetornos = 00;
            retorno.mensagens = "Registro atualizado com sucesso!";
            return retorno;
        }

        public async Task<RetornoCommands> Handle(AvaliarUsuarioCommad request, CancellationToken cancellationToken)
        {
            
            try
            {
                var usuario = await _repository.findById(request.Id);
                switch (request.Situacao)
                {
                    case "Liberado":
                        usuario.AlterarSituacao(ESituacaoUsuario.Liberado);
                        break;
                    case "Negado":
                        usuario.AlterarSituacao(ESituacaoUsuario.Negado);
                        break;
                    case "Pendente":
                        usuario.AlterarSituacao(ESituacaoUsuario.Pendente);
                        break;
                    default:                        
                        break;
                }

                await _repository.update(request.Id,usuario);
                
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception e)
            {
                return new RetornoCommands { mensagens = e.Message.ToString()};
            }
            
        }

        public async Task<RetornoCommands> Handle(CriarUsuarioCommand request, CancellationToken cancellationToken)
        {
            /*fazer o mapper*/
            var email = new Email(request.Email);
            var login = new LoginUsuario(request.Perfil, request.Senha, email);
            var usuario = new Usuarios( request.Nome, request.NumCasa, request.DataNascimento, request.Telefone, login);
            if (usuario.Invalid)
                return new RetornoCommands { codRetornos = 01, mensagens = "Dados do Usuário invalido" };
            await _repository.insert(usuario);
            var retorno = new RetornoCommands();
            retorno.codRetornos = 00;
            retorno.mensagens = "Registro inserido com sucesso!";
            return retorno;
        }

        public async Task<RetornoCommands> Handle(DeletarUsuarioCommand request, CancellationToken cancellationToken)
        {
            /*fazer o mapper*/
            await _repository.delete(request.Id);
            var retorno = new RetornoCommands();
            retorno.codRetornos = 00;
            retorno.mensagens = "Registro apagado com sucesso!";
            return retorno;
        }
    }
}