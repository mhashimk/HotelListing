using HotelListing.API.CoreModels;
using Microsoft.Build.Execution;
using static HotelListing.API.CoreModels.QueryParameters;

namespace HotelListing.API.CoreContracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);

        Task<TResult> GetAsync<TResult>(int? id);

        Task<List<T>> GetAllAsync();
        Task<List<TResult>> GetAllAsync<TResult>();

        Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);

        Task<T> AddAsync(T entity);
        Task<TResult> AddAsync<TSource,TResult>(TSource source);

        Task DeleteAsync(int id);

        Task UpdateAsync(T entity);
        Task UpdateAsync<Tsource>(int id, Tsource source);

        Task<bool> Exists(int id);

    }
}
