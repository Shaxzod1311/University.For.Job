using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.IRepositories;
using University.Domain.Common;
using University.Domain.Entities;
using University.Domain.PagginationConfig;
using University.Service.DTOs;
using University.Service.Interfaces;

namespace University.Service.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository cityRepository;
        public BaseResponse<City> response = new BaseResponse<City>();
        public CityService(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public async Task<BaseResponse<City>> CreateAsync(CityDTO entity)
        {
            string query = $"insert into \"Cities\" (Name, CreatedDate, LastUpdatedDate, isDeleted)"
                + $"values('{entity.Name}', '')";

            var result = await cityRepository.CreateAsync(query, null, CommandType.StoredProcedure);

            response.Data = result;
            return response;
        }

        public Task<BaseResponse<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<City>>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<City>> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<City>> UpdateAsync(CityDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
