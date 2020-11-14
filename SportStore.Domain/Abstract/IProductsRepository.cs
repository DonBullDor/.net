using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportStore.Domain.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
