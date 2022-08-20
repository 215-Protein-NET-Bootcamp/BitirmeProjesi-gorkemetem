using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
    }
}
