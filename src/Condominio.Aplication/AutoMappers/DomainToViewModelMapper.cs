using AutoMapper;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Aplication.AutoMappers
{
    public class DomainToViewModelMapper : Profile
    {
        public DomainToViewModelMapper()
        {
            CreateMap<Usuario,UsuarioViewModel>();
            CreateMap<Avisos,AvisosViewModel>();
            CreateMap<CondominioEnd,CondominioViewModel>();
            CreateMap<Despesa,DespesaViewModel>();
            CreateMap<Documento,DocumentoViewModel>();
            CreateMap<Endereco,EnderecoViewModel>();
            CreateMap<Fornecedor,FornecedorViewModel>();
            CreateMap<LoginUsuario,LoginViewModel>();
            CreateMap<Ocorrencia,OcorrenciaViewModel>();
            CreateMap<OrdemDeServico,OrdemServicoViewModel>();
            CreateMap<PrestadorServico,PrestadorServicoViewModel>();
            CreateMap<Reserva,ReservaViewModel>();
        }
    }
}