﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Entities
{
    public class Peyment
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        //
        public Order Order { get; set; }
    }
}
