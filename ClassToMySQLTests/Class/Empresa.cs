using System;
using System.Collections.Generic;
using System.Text;

namespace gData.Tests
{
    public class Empresa
    {
        public long Id { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
    }
}
