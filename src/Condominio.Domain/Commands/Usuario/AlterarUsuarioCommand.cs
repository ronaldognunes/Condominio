using System;
using MediatR;

namespace Condominio.Domain.Commands.Usuario
{
    public class AlterarUsuarioCommand : UsuarioCommand, IRequest<RetornoCommands>
    {
        public AlterarUsuarioCommand(string idUsuario ,string Nome,int NumCasa,DateTime dataNascimento,int telefone,string perfil,string senha,string email,string situacao)
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