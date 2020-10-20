using AutoMapper;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Commands.Avisos;
using Condominio.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Services
{
    public class AvisoService : IAvisoService
    {
        private readonly IMapper _mapper;
        private readonly IAvisosRepository _avisoRepository;
        private readonly IMediator _handler;

        public AvisoService(IMapper mapper, IAvisosRepository repository , IMediator handler)
        {
            _mapper = mapper;
            _avisoRepository = repository;
            _handler = handler;
        }
        public Task<RetornoViewModel> AlterarAviso(AvisosViewModel aviso)
        {
            throw new NotImplementedException();
        }

        public async Task<AvisosViewModel> ConsultarAviso(string id)
        {
            var result = await _avisoRepository.findById(id);
            var aviso = new AvisosViewModel
            {
                tipo = result.tipo,
                descricao = result.descricao,
                dataEnvio = result.dataEnvio,
                dataGeracao = result.dataGeracao,
                situacao = result.situacao
            };
            return aviso;
        }

        public async Task<RetornoViewModel> ExcluirAviso(string id)
        {
            try
            {
                var command = new ExcluirAvisoCommand(id);
                var result = await _handler.Send(command);
                return new RetornoViewModel { MsgRetorno = result.mensagens };
            }
            catch (Exception e)
            {
                return retornoErro(e);
            }
        }

        public async Task<IList<AvisosViewModel>> ExibirTodosAviso()
        {
            var result = new List<AvisosViewModel>();
            var avisos = await  _avisoRepository.findAll();
            foreach( var item in avisos)
            {
                var aviso = new AvisosViewModel 
                { 
                    tipo = item.tipo,
                    descricao = item.descricao,
                    dataEnvio = item.dataEnvio,
                    dataGeracao = item.dataGeracao,
                    situacao = item.situacao
                };
            }
            return result;
        }

        public async Task<RetornoViewModel> IncluirAvisos(AvisosViewModel aviso)
        {
            try
            {
                var command = new IncluirAvisoCommand(aviso.descricao, aviso.tipo, aviso.situacao);
                var result = await _handler.Send(command);
                return new RetornoViewModel { MsgRetorno = result.mensagens };
            }
            catch (Exception e)
            {
                return retornoErro(e);
            }
        }

        private RetornoViewModel retornoErro(Exception e)
        {
            return new RetornoViewModel { MsgRetorno = e.Message.ToString() };
        }
    }
}
