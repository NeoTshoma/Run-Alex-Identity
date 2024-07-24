namespace Run_AC_Identity.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetAsync(string id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<List<T>> AddRange(List<T> entities);
        Task<bool> Exists(string id);
        Task DeleteAsync(string id);
        Task UpdateAsync(T entity);
    }
}