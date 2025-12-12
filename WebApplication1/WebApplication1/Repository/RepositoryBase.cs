using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace WebApplication1.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected VehicleContext RepositoryContext { get; set; }
        public RepositoryBase(VehicleContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
    }
}
