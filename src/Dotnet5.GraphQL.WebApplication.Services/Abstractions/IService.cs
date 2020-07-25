using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dotnet5.GraphQL.WebApplication.Domain.Abstractions;
using Dotnet5.GraphQL.WebApplication.Services.Models;

namespace Dotnet5.GraphQL.WebApplication.Services.Abstractions
{
    public interface IService<TEntity, in TModel, in TId>
        where TEntity : Entity<TId>
        where TModel : Model<TId>
        where TId : struct
    {
        void Delete(TId id);
        Task DeleteAsync(TId id, CancellationToken cancellationToken);

        TEntity Edit(TModel model);
        Task<TEntity> EditAsync(TModel model, CancellationToken cancellationToken);

        bool Exists(TId id);
        Task<bool> ExistsAsync(TId id, CancellationToken cancellationToken);

        IList<TEntity> GetAll();
        Task<IList<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        TEntity GetById(TId id);
        Task<TEntity> GetByIdAsync(TId id, CancellationToken cancellationToken);

        TEntity Save(TModel model);
        Task<TEntity> SaveAsync(TModel model, CancellationToken cancellationToken);
    }
}