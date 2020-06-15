using System;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Morador : Base
    {
        public string Nome { get; set; }
        public int NumCasa { get; set; }
        public Email  email { get; set; }
        public DateTime dataNascimento { get; set; }
        public int telefone { get; set; }
        public bool sindico { get; set; }
        public string senha { get; set; }
        public string situacao { get; set; }
    }
}