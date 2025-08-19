﻿using System.ComponentModel;

namespace Academico.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        [DisplayName("E-mail")]   
        public string Email { get; set; }

        [DisplayName("CEP")]
        public long Cep { get; set; }


    }
}
