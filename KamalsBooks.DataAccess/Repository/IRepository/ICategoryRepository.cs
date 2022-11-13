using System;
using System.Collections.Generic;
using System.Text;
using KamalsBooks.Models;
using KamalsBooks.DataAccess.Repository.IRepository;
using KamalsBookStore.DataAccess.Data;
using System.Linq;
using System.Threading.Tasks;

namespace KamalsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}