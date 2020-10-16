using System;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;
using Condominio.Domain.objetosDeValor.Enums;
using Flunt.Validations;

namespace Condominio.Domain.Entidades
{
    public class Usuarios : Entidade 
    {
        public Usuarios( string nome, int numCasa, DateTime dataNascimento, int telefone, LoginUsuario login)
        {   
            this.Nome = nome;
            this.NumCasa = numCasa;
            this.DataNascimento = dataNascimento;
            this.Telefone = telefone;
            this.Login  = login;       
            Situacao = ESituacaoUsuario.pendente;
            AddNotifications(login, new Contract().Requires()
             .IsNotNull(numCasa,"numCasa","Número da casa não informado.")
             .IsNotNull(dataNascimento,"dataNascimento","Data de nascimento não informado.")
             .IsNotNull(telefone,"telefone","telefone não informado.")
             .IsNullOrEmpty(nome,"nome","Nome não informado")
             );
        }
        public string Nome { get; private set; }
        public int NumCasa { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Telefone { get; private set; }
        public ESituacaoUsuario Situacao { get; private  set; }
        public LoginUsuario Login { get; private set; }
    }
}