using System.Text.Json.Serialization;

namespace Permissions.Models
{
    public class Permission
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EntityGroup { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public int TotalCount { get; set; }
    }
}
