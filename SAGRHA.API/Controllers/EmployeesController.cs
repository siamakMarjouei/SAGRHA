// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using SAGRHA.API.Data;

// namespace SAGRHA.API.Controllers
// {
//     [Authorize]
//     [Route("api/[controller]")]
//     [ApiController]
//     public class EmployeesController : ControllerBase
//     {
//         private readonly ISagrhaRepository _repo;
//         public EmployeesController(ISagrhaRepository repo)
//         {
//             _repo = repo;

//         }

//         [HttpGet]
//         public async Task<IActionResult> getEmployees()
//         {
//             return await _repo.GetAll()
//         }

//     }
// }