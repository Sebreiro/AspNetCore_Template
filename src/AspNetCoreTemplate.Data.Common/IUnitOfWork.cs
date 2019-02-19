using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreTemplate.Data.Common
{
    public interface IUnitOfWork
    {
        //IRepository<TestModel> TestModelRepository { get; }

        void Commit();

        void CommitAsync();
    }
}
