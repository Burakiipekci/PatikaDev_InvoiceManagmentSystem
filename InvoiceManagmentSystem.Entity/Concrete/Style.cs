﻿using InvoiceManagmentSystem.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Entity.Concrete
{
    public class Style:IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
