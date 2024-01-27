namespace HR.LeaveManagement.Application.Persistance
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync();
        Task<T> GetByIdAsync();
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);

    }

}