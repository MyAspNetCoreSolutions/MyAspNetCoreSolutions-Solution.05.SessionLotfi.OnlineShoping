﻿using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Contract.ApplicationService
{
    public interface IProductService
    {
        void Add(Product product);
    }
}
