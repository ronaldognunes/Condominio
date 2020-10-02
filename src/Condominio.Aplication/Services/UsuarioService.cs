using AutoMapper;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Commands.Usuario;
using Condominio.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _handler;
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IMapper mapper, IMediator mediator, IUsuarioRepository repository)
        {
            _mapper = mapper;
            _handler = mediator;
            _repository = repository;
        }
        public async Task<RetornoViewModel> ApagarAsync(string id)
        {
            /*criar mapper*/
            var command = new DeletarUsuarioCommand(id);
            var retornocommand = await _handler.Send(command);
            var retorno = new RetornoViewModel { MsgRetorno = retornocommand.mensagens};
            return retorno;
        }

        public async Task<RetornoViewModel> AtualizarAsync(UsuarioViewModel usuario)
        {
            /*criar mapper*/
            var command = new AlterarUsuarioCommand(usuario.id,usuario.nome,usuario.numCasa,usuario.DataNascimento,usuario.telefone,usuario.login.pefil,usuario.login.senha,usuario.login.email,usuario.situacao);
            var retornocommand = await _handler.Send(command);
            var retorno = new RetornoViewModel { MsgRetorno = retornocommand.mensagens };
            return retorno;
        }

        public async Task<UsuarioViewModel> LogarAsync(UsuarioViewModel usuario)
        {
            var retornorepositorio = await _repository.findById(usuario.id);
            var retorno = new UsuarioViewModel
            {
                id = retornorepositorio.id,
                nome = retornorepositorio.Nome,
                DataNascimento = retornorepositorio.dataNascimento
            };
            return retorno;
        }

        public async Task<RetornoViewModel> RegistrarAsync(UsuarioViewModel usuario)
        {
            /*criar mapper*/
            var command = new CriarUsuarioCommand( usuario.nome, usuario.numCasa, usuario.DataNascimento, usuario.telefone, usuario.login.pefil, usuario.login.senha, usuario.login.email, usuario.situacao);
            var retornocommand = await _handler.Send(command);
            var retorno = new RetornoViewModel { MsgRetorno = retornocommand.mensagens };
            return retorno;
        }

        public async Task<IList<UsuarioViewModel>> RetornarUsuariosAsync()
        {
            var lista = new List<UsuarioViewModel>();
            var retornorepositorio = await _repository.findAll();
            foreach (var item in retornorepositorio)
            {
                var retorno = new UsuarioViewModel
                {
                    id = item.id,
                    nome = item.Nome,
                    DataNascimento = item.dataNascimento
                };
                lista.Add(retorno);
            }
           return lista;
        }
    }
}
