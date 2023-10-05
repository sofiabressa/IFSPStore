using IFStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto() { }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateOnly DataCompra { get; set; }
        public string UnidadeVenda { get; set; }
        public Grupo Grupo { get; set; }

    }
}
