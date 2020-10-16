using System;
using MediatR;

namespace Condominio.Domain.Commands.Usuario
{
    public class CriarUsuarioCommand : UsuarioCommand, IRequest<RetornoCommands>
    {
        public CriarUsuarioCommand(string Nome,int NumCasa,DateTime dataNascimento,int telefone,string perfil,string senha,string email,string situacao)
        {
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