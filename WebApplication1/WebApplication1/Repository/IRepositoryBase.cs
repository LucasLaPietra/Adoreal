namespace WebApplication1.Repository
{
    public interface IRepositoryBase<T>
    {
        void Create(T entity);
    }
}
