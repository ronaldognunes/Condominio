using System;
using MediatR;

namespace Condominio.Domain.Commands.Usuario
{
    public class AlterarUsuarioCommand : UsuarioCommand, IRequest<RetornoCommands>
    {
        public AlterarUsuarioCommand(string Id, string Nome,int NumCasa,DateTime dataNascimento,int telefone,string perfil,string senha,string email,string situacao)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.NumCasa = NumCasa;
            this.DataNascimento = dataNascimento;
            this.Telefone = telefone;
            this.Perfil =perfil;
            this.Senha = senha;
            this.Situacao = situacao;
        }
    }
}