using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        Cliente GetClienteByEmailESenha(string email, string senha);
    }
}
