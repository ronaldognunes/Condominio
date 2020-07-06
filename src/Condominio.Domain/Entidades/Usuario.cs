using System;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;
using Condominio.Domain.objetosDeValor.Enuns;
using Flunt.Validations;

namespace Condominio.Domain.Entidades
{
    public class Usuario : Entidade 
    {
        public Usuario( string nome, int numCasa, DateTime dataNascimento, int telefone, LoginUsuario login)
        {   
            this.Nome = nome;
            this.NumCasa = numCasa;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.login  = login;       
            situacao = ESituacaoUsuario.pendente;
            AddNotifications(login, new Contract()
             .IsNotNull(numCasa,"numCasa","Número da casa não informado.")
             .IsNotNull(dataNascimento,"dataNascimento","Data de nascimento não informado.")
             .IsNotNull(telefone,"telefone","telefone não informado.")
             .IsNullOrEmpty(nome,"nome","Nome não informado")
             );
        }
        public string Nome { get; private set; }
        public int NumCasa { get; private set; }
        public DateTime dataNascimento { get; private set; }
        public int telefone { get; private set; }
        public string senha { get; private set; }
        public ESituacaoUsuario situacao { get; private  set; }
        public LoginUsuario login { get; private set; }
    }
}