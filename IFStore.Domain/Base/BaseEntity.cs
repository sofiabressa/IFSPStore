﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain.Base
{
    public abstract class BaseEntity<TId>
    {
        public virtual TId Id { get; set; }
    }
}
