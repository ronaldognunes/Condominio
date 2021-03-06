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
            CreateMap<UsuarioViewModel,Usuarios>()
                .ConstructUsing(c => new Usuarios(c.Id, c.Nome,c.NumCasa,c.DataNascimento,c.Telefone, new LoginUsuario(c.Perfil,c.Senha, new Email(c.Email))) );
            CreateMap<AvisosViewModel,Aviso>();
            CreateMap<CondominioViewModel,CondominioEnd>();
            CreateMap<DespesaViewModel,Despesas>();
            CreateMap<DocumentoViewModel,Documento>();
            CreateMap<EnderecoViewModel,Endereco>();
            CreateMap<FornecedorViewModel,Fornecedor>();
            CreateMap<LoginViewModel,LoginUsuario>();
            CreateMap<OcorrenciaViewModel,Ocorrencias>();
            CreateMap<OrdemServicoViewModel,OrdemDeServico>();
            CreateMap<PrestadorServicoViewModel,PrestadorServico>();
            CreateMap<ReservaViewModel,Reservas>();
            CreateMap<UsuarioViewModel, AlterarUsuarioCommand>()
                .ConvertUsing( c => new AlterarUsuarioCommand(c.Id,c.Nome,c.NumCasa,c.DataNascimento,c.Telefone,c.Perfil,c.Senha,c.Email,c.Situacao));
            CreateMap<UsuarioViewModel, AvaliarUsuarioCommad>()
                .ConstructUsing(c => new AvaliarUsuarioCommad(c.Id, c.Situacao));
            CreateMap<UsuarioViewModel, CriarUsuarioCommand>()
                .ConstructUsing(c => new CriarUsuarioCommand(c.Nome,c.NumCasa,c.DataNascimento,c.Telefone,c.Perfil,c.Senha,c.Email,c.Situacao));

        }
    }
}