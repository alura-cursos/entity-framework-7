using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entidades
{
    public class Venda
    {
        public int ID { get; set; }
        public virtual Usuario Cliente { get; set; }
        public int ClienteID { get; set; }

        public IList<ProdutoVenda> ProdutoVenda { get; set; }

    }
}
