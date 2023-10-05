using IFStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public String Nome { get; set; }
        public String Senha { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataLogin { get; set; }
        public bool Ativo { get; set; }

    }
}
