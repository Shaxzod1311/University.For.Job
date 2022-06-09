using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace University.Data.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        public string ConString { get; set; }
        Task<T> CreateAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null);

        Task<T> UpdateAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null);

        Task<bool> DeleteAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null);

        Task<T> GetAsync(string query, CommandType? cmdType = null);
        Task<IEnumerable<T>> GetAllAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null);
    }
}
