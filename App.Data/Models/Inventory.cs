﻿using System;
using System.Collections.Generic;

namespace App.Data
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public int LocationId { get; set; }
        public int ItemId { get; set; }

        public Item Item { get; set; }
        public Location Location { get; set; }
    }
}
