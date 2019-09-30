using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using SAGRHA.API.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SAGRHA.API.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            var userId = int.Parse(resultContext.HttpContext.User
            .FindFirst(ClaimTypes.NameIdentifier).Value);
            var repo = resultContext.HttpContext.RequestServices.GetService<ISagrhaRepository>();
            var user = await repo.GetById(userId);
            user.LastActive =DateTime.Now;
            await repo.SaveAll();
        }
    }
}