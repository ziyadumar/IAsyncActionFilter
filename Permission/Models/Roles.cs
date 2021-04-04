using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permissions.Models
{
    public class Role
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public long? OrganizationId { get; set; }
        public string EntityGroup { get; set; }
        public string Description { get; set; }
        public List<Permission> Permissions { get; set; }

        [JsonIgnore]
        public int TotalCount { get; set; }
    }

    public class RolePermission
    {
        public long RoleId { get; set; }
        public long PermissionId { get; set; }
    }

    public class UserRole
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public long OrganizationId { get; set; }
        [JsonIgnore]
        public string Entity { get; set; }
    }

    public class UserPermissions
    {
        public int UserID { get; set; }
        public int OrganizationID { get; set; }
        public string Entity { get; set; }
        public List<Permission> Permissions { get; set; }
    }

    public class UserPermission
    {
        public long UserId { get; set; }
        public long PermissionId { get; set; }
        public long OrganizationId { get; set; }
        public string PermissionName { get; set; }
        public string Entity { get; set; }
        public string EntityGroup { get; set; }
        public long RoleId { get; set; }
        public string RoleDescription { get; set; }
        public string PermissionDescription { get; set; }
    }
}
