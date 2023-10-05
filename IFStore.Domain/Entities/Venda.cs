using IFStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public Venda() { }
        public DateTime Data { get; set; }
        public decimal ValorToral { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public List<VendaItem> Items { get; set; }
    }

    public class VendaItem : BaseEntity<int>
    {
        public VendaItem() { }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
