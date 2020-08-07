using System;

namespace Condominio.Aplication.ViewModels
{
    public class UsuarioViewModel
    {
        public string id { get; set; }
        public string nome { get; set; }
        public int numCasa { get; set; }
        public int telefone { get; set; }
        public LoginViewModel login { get; set; }
        public DateTime DataNascimento { get; set; }  
        public int situacao { get; set; }   
        
    }
}