using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using University.Domain.Common;
using University.Domain.Entities;
using University.Domain.PagginationConfig;
using University.Service.DTOs;
using University.Service.Interfaces;

namespace University.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponse<IEnumerable<Student>>>> GetAllAsync([FromQuery] PaginationParams @params)
        {
            var result = await studentService.GetAllAsync(@params);

            return StatusCode(200, result);
        }

        [HttpGet]   
        [Route("{id}")]
        public async Task<ActionResult<BaseResponse<Student>>> GetAsync([FromQuery]Guid id)
        {
            var result = await studentService.GetAsync(id);

            return StatusCode(200, result);
        }
        
        [HttpPost]
        public async Task<ActionResult<BaseResponse<Student>>> CreateAsync([FromBody] StudentDTO entity)
        {
            var result = await studentService.CreateAsync(entity);

            return StatusCode(200, result);
        }
        
        [HttpPut]
        public async Task<ActionResult<BaseResponse<Student>>> UpdateAsync([FromBody] StudentDTO entity)
        {
            var result = await studentService.UpdateAsync(entity);

            return StatusCode(200, result);
        }
        
        [HttpDelete]
        public async Task<ActionResult<BaseResponse<bool>>> DeleteAsync([FromQuery] Guid id)
        {
            var result = await studentService.DeleteAsync(id);

            return StatusCode(200, result);
        }
    }
}
