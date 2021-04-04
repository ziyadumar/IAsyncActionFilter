using Microsoft.Extensions.Options;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Permissions.Interfaces;

namespace Permissions.Repositories
{
    public class RoleVerificationRepository : IRoleVerificationRepository
    {
        //     private ConnectionManager _connectionManager;
        //
        //     public RoleVerificationRepository(IOptions<AppConfiguration> options)
        //     {
        //         _connectionManager = new ConnectionManager(options);
        //     }
        //
        //     public async Task<bool> VerifyUser(long userId, long organisationId, string permissionName)
        //     {
        //         try
        //         {
        //             using(IDbConnection dbConnection = _connectionManager.Create())
        //             {
        //                 string qu = @"WITH RECURSIVE c AS (
        //                 SELECT @parentId AS id
        //                 UNION ALL
        //                 SELECT ct.Id
        //                     FROM Categories AS ct
        //                     JOIN c ON c.id = ct.ParentId
        //                     )
        //                 SELECT id FROM c;";
        //                 
        //                 
        //                 string sql = @"SELECT * FROM UserRoles WHERE UserId = @userId AND OrganizationId = ANY(WITH RECURSIVE c AS (
        //                 SELECT @organisationId AS id
        //                 UNION ALL
        //                 SELECT ct.Id
        //                     FROM restaurants AS ct
        //                     JOIN c ON c.id = ct.ParentId
        //                     )
        //                 SELECT id FROM c) AND RoleId IN
        //                                 (SELECT RoleId FROM RolePermissions WHERE PermissionId IN 
        //                                     (SELECT Id FROM Permissions WHERE Name = @permissionName))
        //                                 ";
        //
        //                 var result = await dbConnection.QueryAsync<UserRole>(sql, new { userId, organisationId, permissionName });
        //
        //                 return result != null && result.Any();
        //             }
        //         }
        //         catch
        //         {
        //             return false;
        //         }
        //     }
        // }
        public Task<bool> VerifyUser(long userId, long organisationId, string permissionName)
        {
            throw new System.NotImplementedException();
        }
    }
}
