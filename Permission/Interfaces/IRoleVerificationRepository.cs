using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Permissions.Interfaces
{
    public interface IRoleVerificationRepository
    {
        Task<bool> VerifyUser(long userId, long organisationId, string permissionName);
    }
}
