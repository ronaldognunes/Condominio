using System;

namespace Condominio.Aplication.ViewModels
{
    public class UsuarioViewModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int NumCasa { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
        public DateTime DataNascimento { get; set; }  
        public string Situacao { get; set; }   
        
    }
}