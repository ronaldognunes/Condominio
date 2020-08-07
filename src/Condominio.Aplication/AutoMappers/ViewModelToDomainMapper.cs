using AutoMapper;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Aplication.AutoMappers
{
    public class ViewModelToDomainMapper:Profile
    {
        public ViewModelToDomainMapper()
        {
            CreateMap<UsuarioViewModel,Usuario>();
            CreateMap<AvisosViewModel,Avisos>();
            CreateMap<CondominioViewModel,CondominioEnd>();
            CreateMap<DespesaViewModel,Despesa>();
            CreateMap<DocumentoViewModel,Documento>();
            CreateMap<EnderecoViewModel,Endereco>();
            CreateMap<FornecedorViewModel,Fornecedor>();
            CreateMap<LoginViewModel,LoginUsuario>();
            CreateMap<OcorrenciaViewModel,Ocorrencia>();
            CreateMap<OrdemServicoViewModel,OrdemDeServico>();
            CreateMap<PrestadorServicoViewModel,PrestadorServico>();
            CreateMap<ReservaViewModel,Reserva>();
        }
    }
}