using AutoMapper;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Commands.Usuario;
using Condominio.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
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
            RetornoViewModel retorno;
            try
            {
                var command = new DeletarUsuarioCommand(id);
                var retornocommand = await _handler.Send(command);
                retorno = new RetornoViewModel { MsgRetorno = retornocommand.mensagens };
            }
            catch(Exception e)
            {
                 retorno = new RetornoViewModel { MsgRetorno = e.Message.ToString() };
            }
            
            return retorno;
        }

        public async Task<RetornoViewModel> AtualizarAsync(UsuarioViewModel usuario)
        {
            var command = _mapper.Map<UsuarioViewModel,AlterarUsuarioCommand>(usuario);
            //var command = new AlterarUsuarioCommand(usuario.Id, usuario.Nome, usuario.NumCasa, usuario.DataNascimento, usuario.Telefone, usuario.Perfil, usuario.Senha, usuario.Email, usuario.Situacao);
            var retornocommand = await _handler.Send(command);
            var retorno = new RetornoViewModel { MsgRetorno = retornocommand.mensagens };
            return retorno;
        }

        public async Task<UsuarioViewModel> LogarAsync(string  id)
        {
            var item = await _repository.findById(id);
            var retorno = new UsuarioViewModel
            {
                Id = item.id,
                Nome = item.Nome,
                DataNascimento = item.DataNascimento,
                Telefone = item.Telefone,
                Email = item.Login.Email.EdEmail,
                Senha = item.Login.Senha,
                Perfil = item.Login.Perfil,
                Situacao = item.Situacao.ToString()
            };
            return retorno;
        }

        public async Task<RetornoViewModel> RegistrarAsync(UsuarioViewModel usuario)
        {
            /*criar mapper*/
            var command = _mapper.Map<CriarUsuarioCommand>(usuario);
            //var command = new CriarUsuarioCommand(usuario.Nome, usuario.NumCasa, usuario.DataNascimento, usuario.Telefone, usuario.Perfil, usuario.Senha,usuario.Email ,usuario.Situacao);
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
                    Id = item.id,
                    Nome = item.Nome,
                    DataNascimento = item.DataNascimento,                    
                    Telefone = item.Telefone,
                    Email = item.Login.Email.EdEmail,
                    Senha = item.Login.Senha,
                    Perfil = item.Login.Perfil,
                    Situacao = item.Situacao.ToString()
                };
                lista.Add(retorno);
            }
           return lista;
        }
    }
}
