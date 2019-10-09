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
                return StatusCode(201);

            return BadRequest("Could not create employee");
        }




    }
}