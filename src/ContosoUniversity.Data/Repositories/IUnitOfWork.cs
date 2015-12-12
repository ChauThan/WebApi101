using System;

namespace ContosoUniversity.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }
}
