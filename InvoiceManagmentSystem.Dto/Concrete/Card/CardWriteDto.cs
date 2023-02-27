﻿using InvoiceManagmentSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagmentSystem.Dto.Concrete.Card
{
    public class CardWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public int CardNumber { get; set; }
        public int CardPassword { get; set; }
        public int Balance { get; set; }
    }
}