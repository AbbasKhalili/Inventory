using Framework.Core;
using System;
using System.Threading.Tasks;

namespace Framework.DataAccess.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _context;

        public UnitOfWork(IDbContext context)
        {
            _context = context;
        }

        public async Task Begin()
        {
            await _context.Instance.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _context.Instance.SaveChangesAsync();
            await _context.Instance.Database.CommitTransactionAsync();
        }

        public async Task Rollback()
        {
            await _context.Instance.Database.RollbackTransactionAsync();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Instance.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
