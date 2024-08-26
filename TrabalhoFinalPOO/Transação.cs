using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalPOO
{
    public class Transação
    {
       public string IdVenda { get; set; }
       public string Vendedor { get; set; }
       public string PreçoT { get; set; }
       public string TipoT { get; set; }
       public string Pagamento { get; set; }
       public string ObservaçõesAdicionaisT { get; set; }
       public DateTime DataCadastro { get; set; }
       public Cliente Cliente { get; set; }
       public Carro Carro { get; set; }
    }



}
