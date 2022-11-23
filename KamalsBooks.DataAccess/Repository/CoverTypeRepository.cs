using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KamalsBooks.DataAccess.Repository.IRepository;
using KamalsBooks.Models;
using KamalsBookStore.DataAccess.Data;

namespace KamalsBooks.DataAccess.Repository
{
    class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // use .NET Linq to retrieve the first or dedault category object
            // then pass the id as generic entiry which matches the category ID
            var objFormDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFormDb != null) // save changes if not null
            {
                objFormDb.Name = coverType.Name;
                //_db.SaveChanges(); Removed this one
            }
        }
    }
}