using Api.Src.Infra.Data.Contexts.Interface;
using Microsoft.EntityFrameworkCore.Storage;

namespace Api.Src.Infra.Data.Contexts
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CatalogoDBContext _catalogoDBContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork(CatalogoDBContext catalogoDBContext)
        {
            _catalogoDBContext = catalogoDBContext;
        }
        public async Task BeginTransaction()
        {
            _transaction = await _catalogoDBContext.Database.BeginTransactionAsync();
        }
        public async Task Commit()
        {
            await _transaction.CommitAsync();
        }
        public async Task Rollback()
        {
            await _transaction.RollbackAsync();
        }
        public void Dispose()
        {
            _transaction?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
