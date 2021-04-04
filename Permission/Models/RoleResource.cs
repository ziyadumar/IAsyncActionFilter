using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Permissions.Models
{
    public class RoleResource
    {
        public long? Id { get; set; }

        [Required]
        public string DisplayName { get; set; }

        public string Name { get; set; }

        public int? OrganisationId { get; set; }

        public string EntityGroup { get; set; }

        public string Description { get; set; }

        [Required]
        public List<long> Permissions { get; set; }

    }
}
