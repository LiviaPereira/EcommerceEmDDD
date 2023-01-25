using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ecommerce.Infra.Data.Repositories
{
    public abstract class EcommerceRepositoryBase
    {
        private IConfigurationRoot _configurationRoot;
        internal IDbConnection ConnectionEcommerce
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                _configurationRoot = builder.Build();
                return new SqlConnection(_configurationRoot.GetConnectionString("DefaultConnectionString"));
            }
        }
    }
}
