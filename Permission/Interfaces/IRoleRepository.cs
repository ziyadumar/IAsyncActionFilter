using System.Collections.Generic;
using System.Threading.Tasks;
using Permissions.Models;
using UnitOfWork.Interfaces;

namespace Permissions.Interfaces
{
    public interface IRoleRepository
    {
        Task<UserRole> AddRole(UserRole userRole, IUnitOfWork uow);
        Task<Role> GetRole(string name);
        Task<IEnumerable<UserRole>> GetRoleUsers(long organizationId, string role);
    }
}


