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
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.perfil =perfil;
            this.senha = senha;
            this.situacao = situacao;
        }
        
    }
}