using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAGRHA.API.Data;
using SAGRHA.API.Dtos;

namespace SAGRHA.API.Controllers
{
    [Authorize]
    [Route("api/employees/{employeeId}/relatives")]
    [ApiController]
    public class RelativesController : ControllerBase
    {
        private readonly ISagrhaRepository _repo;
        private readonly IMapper _mapper;
        public RelativesController(ISagrhaRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }

        [HttpGet("{id}", Name = "GetRelative")]
        public async Task<IActionResult> GetRelative(int id)
        {
            var relativeFromRepo = await _repo.GetRelative(id);

            var relative = _mapper.Map<RelativeToReturnDto>(relativeFromRepo);

            return Ok(relative);
        }


    }
}