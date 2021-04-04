using System.Data;
using Common.Configuration;
using Microsoft.Extensions.Options;
using Npgsql;

namespace Common.Data
{
    public class ConnectionManager
    {
        private IOptions<AppConfiguration> _options;

        public ConnectionManager(IOptions<AppConfiguration> options)
        {
            _options = options;
        }

        public IDbConnection Create()
        {
            string connectionString = _options.Value.ConnectionStrings_Default;
            var connection = new NpgsqlConnection(connectionString);
            return connection;
        }
    }
}