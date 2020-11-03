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
            CreateMap<Usuarios,UsuarioViewModel>();
            CreateMap<Aviso,AvisosViewModel>();
            CreateMap<CondominioEnd,CondominioViewModel>();
            CreateMap<Despesas,DespesaViewModel>();
            CreateMap<Documento,DocumentoViewModel>();
            CreateMap<Endereco,EnderecoViewModel>();
            CreateMap<Fornecedor,FornecedorViewModel>();
            CreateMap<LoginUsuario,LoginViewModel>();
            CreateMap<Ocorrencias,OcorrenciaViewModel>();
            CreateMap<OrdemDeServico,OrdemServicoViewModel>();
            CreateMap<PrestadorServico,PrestadorServicoViewModel>();
            CreateMap<Reservas,ReservaViewModel>();
        }
    }
}