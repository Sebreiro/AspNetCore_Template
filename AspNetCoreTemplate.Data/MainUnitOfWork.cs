using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreTemplate.Data.Common;

namespace AspNetCoreTemplate.Data.Core
{
    public class MainUnitOfWork: IUnitOfWork
    {
        private readonly MainContext _context;

        //public IRepository<TestModel> TestModelRepository => new Repository<TestModel>(_context);

        public MainUnitOfWork(MainContext context)
        {
            _context = context;
        }
        
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void CommitAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
