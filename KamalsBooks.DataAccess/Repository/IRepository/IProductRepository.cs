using System;
using System.Collections.Generic;
using System.Text;
using KamalsBooks.Models;

namespace KamalsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}