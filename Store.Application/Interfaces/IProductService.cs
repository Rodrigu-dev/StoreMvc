﻿using Store.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProducts();
    }
}
