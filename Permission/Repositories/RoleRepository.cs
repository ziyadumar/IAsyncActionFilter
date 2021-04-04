using Dapper;
using Microsoft.Extensions.Options;
using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Common.Configuration;
using Common.Data;
using Permissions.Interfaces;
using Permissions.Models;
using UnitOfWork.Interfaces;

namespace Permissions.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ConnectionManager _connectionManager;

        public RoleRepository(IOptions<AppConfiguration> options)
        {
            _connectionManager = new ConnectionManager(options);
        }

        public async Task<UserRole> AddRole(UserRole userRole, IUnitOfWork uow)
        {
            return await AddRoleTransaction(userRole, uow.Connection, uow.Transaction);
        }

        public async Task<UserRole> AddRoleTransaction(UserRole userRole, IDbConnection connection, IDbTransaction transaction)
        {
            var sql =
            @"INSERT INTO UserRoles(UserId, OrganizationId, RoleId, Entity)
            VALUES(@UserId, @OrganizationId, @RoleId, @Entity)
            RETURNING *";

            var roles = await connection.QueryAsync<UserRole>(sql, userRole, transaction);

            return roles.FirstOrDefault();
        }

        public async Task<Role> GetRole(string name)
        {
            var sql = "SELECT * FROM Roles WHERE Name = @name";

            using (var connection = _connectionManager.Create())
            {
                var data = await connection.QueryAsync<Role>(sql, new { name });

                return data.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<UserRole>> GetRoleUsers(long organizationId, string role)
        {
            var sql =
            @"SELECT ur.* FROM UserRoles ur, Roles r 
            WHERE ur.RoleId = r.Id AND ur.organizationId = @organizationId AND r.name = @role AND r.Hidden = FALSE";

            using (var connection = _connectionManager.Create())
            {
                var data = await connection.QueryAsync<UserRole>(sql, new { organizationId, role });

                return data;
            }
        }
    }
}
