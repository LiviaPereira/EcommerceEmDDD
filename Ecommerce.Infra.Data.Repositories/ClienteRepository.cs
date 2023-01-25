using Dapper;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace Ecommerce.Infra.Data.Repositories
{
    public class ClienteRepository : EcommerceRepositoryBase, IClienteRepository
    {
        private readonly IConfiguration _configuration;

        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        public Cliente GetClienteByEmailESenha(string email, string senha)
        {
            using (IDbConnection connection = ConnectionEcommerce)
            {
                return connection.QueryFirstOrDefault<Cliente>(
                    "GetClienteByEmailESenha",
                    new
                    {
                        email = email,
                        senha = senha
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}