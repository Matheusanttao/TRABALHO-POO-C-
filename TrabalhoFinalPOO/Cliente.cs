using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalPOO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPFCNPJ { get; set; }
        public Endereço Endereço { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
