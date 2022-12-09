using System;
using System.Collections.Generic;
using System.Text;
using KamalsBooks.Models;

namespace KamalsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType covertype);
    }
}
