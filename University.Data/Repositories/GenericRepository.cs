using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using University.Data.IRepositories;
using University.Domain.Common;

namespace University.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public string ConString { get; set; }

        public async Task<T> CreateAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null)
        {

            try
            {
                using (var connection = CreateConnection(ConString))
                {
                    return await connection.QueryFirstAsync<T>(query, parameters, commandType: cmdType);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> DeleteAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null)
        {
            try
            {
                using (var connection = CreateConnection(ConString))
                {
                    return await connection.ExecuteAsync(query, parameters, commandType: cmdType) > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null)
        {
            try
            {
                using (var connection = CreateConnection(ConString))
                {
                    return await connection.QueryAsync<T>(query, parameters, commandType: cmdType);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<T> GetAsync(string query, CommandType? cmdType = null)
        {
            try
            {
                using (var connection = CreateConnection(ConString))
                {
                    return await connection.QueryFirstOrDefaultAsync<T>(query, commandType: cmdType);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<T> UpdateAsync(string query, DynamicParameters parameters = null, CommandType? cmdType = null)
        {
            try
            {
                using (var connection = CreateConnection(ConString))
                {
                    return await connection.QueryFirstOrDefaultAsync<T>(query, commandType: cmdType);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        protected IDbConnection CreateConnection(string ConnectionString)
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}
