using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using University.Domain.Common;
using University.Domain.PagginationConfig;

namespace University.Service.Interfaces
{
    public interface IGenericService<T, TSource> where T : BaseEntity
    {
        Task<BaseResponse<T>> GetAsync(Guid id);
        Task<BaseResponse<IEnumerable<T>>> GetAllAsync(PaginationParams @params);
        Task<BaseResponse<T>> CreateAsync(TSource entity);
        Task<BaseResponse<T>> UpdateAsync(TSource entity);
        Task<BaseResponse<bool>> DeleteAsync(Guid id);
    }

}
