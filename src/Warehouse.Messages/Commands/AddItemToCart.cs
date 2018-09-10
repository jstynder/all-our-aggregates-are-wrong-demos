﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.Messages.Commands
{
    public class AddItemToCart
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public Guid CartId { get; set; }
        public string RequestId { get; set; }
    }
}