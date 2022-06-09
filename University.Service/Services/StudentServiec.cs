using AutoMapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using University.Data.IRepositories;
using University.Domain.Common;
using University.Domain.Entities;
using University.Domain.PagginationConfig;
using University.Service.DTOs;
using University.Service.Extensions;
using University.Service.Interfaces;

namespace University.Service.Services
{
    public class StudentServiec : IStudentService
    { 
        private readonly IStudentRepository studentRepository;
        private readonly IConfiguration config;
        private readonly IMapper mapper;
        private readonly BaseResponse<Student> response = new BaseResponse<Student>();

        public StudentServiec(IStudentRepository studentRepository, IConfiguration configuration,
            IMapper mapper)
        {
            this.studentRepository = studentRepository;
            config = configuration;
            this.studentRepository.ConString = config.GetConnectionString("UniversityDb");
            this.mapper = mapper;

        }

        public async Task<BaseResponse<Student>> CreateAsync(StudentDTO entity)
        {

            string query = @"select *from CreateStudetn";
            DynamicParameters prams = new DynamicParameters();
            
            prams.AddDynamicParams(entity);
            var result = await studentRepository.CreateAsync(query, prams, CommandType.StoredProcedure);

            response.Data = result;
            return response;
        }

        public async Task<BaseResponse<IEnumerable<Student>>> GetAllAsync(PaginationParams @params)
        {
            BaseResponse<IEnumerable<Student>> response = new BaseResponse<IEnumerable<Student>>();

            string query = "select *from \"Students\"";
            var result = await studentRepository.GetAllAsync(query, cmdType: CommandType.Text);

            response.Data = result.ToPagesList(@params);
            return response;
        }

        public async Task<BaseResponse<Student>> GetAsync(Guid id)
        {
            string query = $"select *from \"Students\" where \"id\" = {id}";

            var result = await studentRepository.GetAsync(query, CommandType.Text);

            response.Data = result;
            return response;
        }

        public async Task<BaseResponse<Student>> UpdateAsync(StudentDTO entity)
        {
            string query = @"select *from UpdateStudent";
            DynamicParameters parms = new DynamicParameters();
            
            parms.AddDynamicParams(entity);

            var result = await studentRepository.UpdateAsync(query, parms, CommandType.StoredProcedure);

            response.Data = result;

            return response;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(Guid id)
        {
            BaseResponse<bool> response = new BaseResponse<bool>();
            string query = @"select *from DeleteStudent";
            DynamicParameters parms = new DynamicParameters(
                new { id = id });

            var result = await studentRepository.DeleteAsync(query, parms, CommandType.StoredProcedure);

            response.Data = result;

            return response;

        }
    }
}
