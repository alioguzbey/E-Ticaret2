﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Core.DataAcses;
using Etic.Data.Abstract;
using Etic.Entities;

namespace Etic.Data.Concrete
{
    public class BasketProductDal : EfEntityRepositoryBase<BasketProduct,EticContext> , IBasketProductDal
    {
    }
}
