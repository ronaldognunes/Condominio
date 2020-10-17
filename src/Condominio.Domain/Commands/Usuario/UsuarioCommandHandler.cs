using System.Threading;
using System.Threading.Tasks;
using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Domain.objetosDeValor;
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
                request.Nome, 
                request.NumCasa, 
                request.DataNascimento, 
                request.Telefone,  
                new LoginUsuario(request.Perfil, request.Perfil, new Email(request.Email)));
            usuario.id = request.Id;

            if (usuario.Invalid)
                return new RetornoCommands { codRetornos = 01, mensagens = "Dados do Usuário invalido"};

            await _repository.update(request.Id, usuario);
            var retorno = new RetornoCommands();
            retorno.codRetornos = 00;
            retorno.mensagens = "Registro atualizado com sucesso!";
            return retorno;
        }

        public Task<RetornoCommands> Handle(AvaliarUsuarioCommad request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<RetornoCommands> Handle(CriarUsuarioCommand request, CancellationToken cancellationToken)
        {
            /*fazer o mapper*/
            var email = new Email("ronaldo2385nunes@gmail.com");
            var login = new LoginUsuario("admin", "1234", email);
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