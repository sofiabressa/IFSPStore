using IFStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente() { }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string Bairro { get; set; }
        public Cidade Cidade { get; set; }
    }
}
