﻿using InvoiceManagmentSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Style
{
    public class StyleWriteDto : IWriteDto
    {
        public string Name { get; set; }
    }
}
