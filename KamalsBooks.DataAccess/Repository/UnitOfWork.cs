using KamalsBooks.DataAccess.Repository.IRepository;
using KamalsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KamalsBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            //Product = new ProductRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        ICategoryRepository IUnitOfWork.Category => throw new NotImplementedException();

        ICoverTypeRepository IUnitOfWork.CoverType => throw new NotImplementedException();

        ISP_Call IUnitOfWork.SP_Call => throw new NotImplementedException();

        public ICoverTypeRepository CoverType { get; private set; }
        //public IProductRepository Product { get; private set; }


        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.Save()
        {
            throw new NotImplementedException();
        }
    }

}