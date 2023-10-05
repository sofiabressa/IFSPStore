using IFStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Entities
{
    public class Grupo : BaseEntity<int>
    {
        public Grupo() { }
        public String Nome { get; set; }
    }
}
