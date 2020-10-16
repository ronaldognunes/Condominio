using AutoMapper;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Commands.Usuario;
using Condominio.Domain.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Aplication.AutoMappers
{
    public class ViewModelToDomainMapper:Profile
    {
        public ViewModelToDomainMapper()
        {
            CreateMap<UsuarioViewModel,Usuarios>();
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
            CreateMap<UsuarioViewModel, AlterarUsuarioCommand>()
                .ConvertUsing( c => new AlterarUsuarioCommand(c.Id,c.Nome,c.NumCasa,c.DataNascimento,c.Telefone,c.Perfil,c.Senha,c.Email,c.Situacao));
            CreateMap<UsuarioViewModel, AvaliarUsuarioCommad>()
                .ConstructUsing(c => new AvaliarUsuarioCommad(c.Id, c.Situacao));
            CreateMap<UsuarioViewModel, CriarUsuarioCommand>()
                .ConstructUsing(c => new CriarUsuarioCommand(c.Nome,c.NumCasa,c.DataNascimento,c.Telefone,c.Perfil,c.Senha,c.Email,c.Situacao));

        }
    }
}