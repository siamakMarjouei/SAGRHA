using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAGRHA.API.Data;
using SAGRHA.API.Dtos;
using SAGRHA.API.Models;

namespace SAGRHA.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ISagrhaRepository _repo;
        private readonly IMapper _mapper;
        public EmployeesController(ISagrhaRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeForRegisterDto employeeForRegisterDto)
        {
            if(await _repo.EmployeeExist(employeeForRegisterDto.DNI))
                return BadRequest("Employee with DNI already exist");

            var employeeToCreate = _mapper.Map<Employee>(employeeForRegisterDto);
            
            _repo.Add(employeeToCreate);

            if(await _repo.SaveAll())
            {
                var employeeToReturn = _mapper.Map<EmployeesForListDto>(employeeToCreate);
                return Ok(employeeToReturn);
            }
                

            return BadRequest("Could not create employee");
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
             var employees = await _repo.GetEmployees();

             var employeesToReturn =  _mapper.Map<List<EmployeesForListDto>>(employees);

             return Ok(employeesToReturn); 
        }

        [HttpGet("{id}", Name="GetEmployee")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _repo.GetEmployee(id);

            var employeeToReturn = _mapper.Map<EmployeesForListDto>(employee);

            return Ok(employeeToReturn);
        }




    }
}