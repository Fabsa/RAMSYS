using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAMSYS.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string PurchaseOrder { get; set; }        
        public int QuantiMin { get; set; }
        public string Locacao { get; set; }
        public string Destino { get; set; }
        public string UserId { get; set; }
        

    }
}
