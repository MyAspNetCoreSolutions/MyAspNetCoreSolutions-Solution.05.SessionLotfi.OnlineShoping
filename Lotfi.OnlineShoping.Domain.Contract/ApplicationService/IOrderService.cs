﻿using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Contract.ApplicationService
{
    public interface IOrderService
    {
        void Add(Order order);
    }
}
