using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Models
{
    public class Contato : Entity
    {
        public string Nome { get; set; }
        public string TelefoneResidencial { get; set; }
        public string Celular { get; set; }

    }
}
