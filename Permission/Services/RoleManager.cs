using System.Collections.Generic;
using System.Linq;
using Permissions.Constants;
using Permissions.Models;

namespace Permissions.Services
{
    public static class RoleManager
    {
        public static bool HavePermission(this IEnumerable<UserPermission> permissions, string PermissionName, int? Entity = null)
        {
            var sEntity = ((Entity == null) ? RoleEntities.All : Entity.ToString());

            var thePerm = permissions.Where(
                x => (
                    (x.Entity == RoleEntities.All || x.Entity == sEntity) &&
                    x.PermissionName == PermissionName
                )
            );

            return thePerm.Any();
        }
    }
}
