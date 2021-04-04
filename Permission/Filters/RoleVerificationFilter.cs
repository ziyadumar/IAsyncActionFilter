using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Permissions.Interfaces;

namespace Permissions.Filters
{
    public class PermissionRequiredAttribute : TypeFilterAttribute
    {
        public PermissionRequiredAttribute(string permission) : base(typeof(RoleVerificationFilter))
        {
            Arguments = new object[] { permission };
        }
    }

    public class RoleVerificationFilter : Attribute, IAsyncActionFilter
    {
        private string _permission;
        private IRoleVerificationRepository _roleVerificationRepository;

        public RoleVerificationFilter(IRoleVerificationRepository roleVerificationRepository, string permission)
        {
            _roleVerificationRepository = roleVerificationRepository;
            _permission = permission;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            long userId = 1;
            // long organizationId = context.HttpContext.GetTenantIdentifier();
            long organizationId = 1;

            if(await _roleVerificationRepository.VerifyUser(userId, organizationId, _permission) == false)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
                return;
            }

            await next();
        }
    }
}
